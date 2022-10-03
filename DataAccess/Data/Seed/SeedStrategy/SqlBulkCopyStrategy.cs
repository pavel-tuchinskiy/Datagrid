
#define TPL
using Domain.Entities;
using Domain.Interfaces.Seeder;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;

namespace DataAccess.Data.Seed.SeedStrategy
{
    public class SqlBulkCopyStrategy : ISeedStrategy
    {
        private readonly IConfiguration _configuration;

        public SqlBulkCopyStrategy(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<TimeSpan> SeedData(IEnumerable<User> users, IEnumerable<Product> products, IEnumerable<Order> orders, IEnumerable<OrderProduct> orderProducts)
        {
            var connection = _configuration.GetConnectionString("SqlConnection");

            var productColumns = typeof(Product).GetProperties().Select(p => p.Name).ToArray();
            var usersColumns = typeof(User).GetProperties().Where(p => p.Name != "Orders").Select(p => p.Name).ToArray();
            var ordersColumns = typeof(Order).GetProperties().Where(p => p.Name != "User" && p.Name != "OrderProducts").Select(p => p.Name).ToArray();
            var orderProductsColumns = typeof(OrderProduct).GetProperties().Where(p => p.Name != "Order" && p.Name != "Product").Select(p => p.Name).ToArray();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

#if Parallel
            Parallel.Invoke(new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount },
                () => SeedSqlBulkCopy(connection, "Users", usersColumns, users),
                () => SeedSqlBulkCopy(connection, "Products", productColumns, products,
                () => SeedSqlBulkCopy(connection, "Orders", ordersColumns, orders),
                () => SeedSqlBulkCopy(connection, "OrdersAndProducts", orderProductsColumns, orderProducts)
            );
#elif TPL
            await SeedSqlBulkCopy(connection, "Users", usersColumns, users);
            await SeedSqlBulkCopy(connection, "Products", productColumns, products);
            await SeedSqlBulkCopy(connection, "Orders", ordersColumns, orders);
            await SeedSqlBulkCopy(connection, "OrdersAndProducts", orderProductsColumns, orderProducts);
#endif

            stopWatch.Stop();
            return stopWatch.Elapsed;
        }

        private async Task SeedSqlBulkCopy<TData>(string connection, string destination, string[] columns, IEnumerable<TData> data)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            using (var bulkCopy = new SqlBulkCopy(sqlConnection, SqlBulkCopyOptions.TableLock, null))
            {
                bulkCopy.DestinationTableName = destination;
                bulkCopy.BatchSize = 1_000_000;
                bulkCopy.BulkCopyTimeout = 0;

                foreach (var column in columns)
                {
                    bulkCopy.ColumnMappings.Add(column, column);
                }

                using (var reader = new ObjectDataReader<TData>(data))
                {
                    sqlConnection.Open();
                    await bulkCopy.WriteToServerAsync(reader);
                    bulkCopy.Close();
                }
            }
        }
    }
}
