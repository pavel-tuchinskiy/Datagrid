using Domain.Entities;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace DataAccess.Data.Seed.SeedStrategy
{
    public class BulkInsertStrategy : ISeedStrategy
    {
        private readonly GridDbContext _dbContext;

        public BulkInsertStrategy(GridDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TimeSpan> SeedData(IEnumerable<User> users, IEnumerable<Product> products, IEnumerable<Order> orders, IEnumerable<OrderProduct> orderProducts)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            await SeedBulk(products, _dbContext);
            await SeedBulk(users, _dbContext);
            await SeedBulk(orders, _dbContext);
            await SeedBulk(orderProducts, _dbContext);

            stopWatch.Stop();
            return stopWatch.Elapsed;
        }

        private async Task SeedBulk(IEnumerable<object> data, GridDbContext dbContext)
        {
            var dataCount = data.Count();

            for (int i = 0; i <= dataCount; i += 1000000)
            {
                await dbContext.BulkInsertAsync(data.Skip(i).Take(1000000), options =>
                {
                    options.TemporaryTableBatchByTable = 2;
                    options.TemporaryTableBatchByTable = 500000;
                    options.TemporaryTableUseTableLock = true;
                    options.UseLogDump = false;
                    options.AutoMap = Z.BulkOperations.AutoMapType.ByName;
                    options.AutoTruncate = false;
                    options.ValidateAllDestinationMapped = false;
                    options.ValidateAllSourceMapped = false;
                    options.SqlBulkCopyOptions = (int)SqlBulkCopyOptions.TableLock;
                    options.BatchDelayInterval = 0;
                    options.IsCheckConstraintOnInsertDisabled = false;
                    options.DisableDotCheckForEscapeTableName = true;
                    options.DisableTemporaryTableClusteredIndex = true;
                    options.DisableInformationSchemaCache = true;
                    options.DisablePrimaryKeyNullCheck = true;
                    options.DisableValueGenerated = true;
                    options.AutoMapOutputDirection = false;
                    options.InsertKeepIdentity = false;
                    options.BatchSize = 500000;
                });
            }
        }
    }
}
