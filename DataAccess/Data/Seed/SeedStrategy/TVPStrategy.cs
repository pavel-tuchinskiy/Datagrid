using Domain.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient.Server;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Diagnostics;

namespace DataAccess.Data.Seed.SeedStrategy
{
    public class TVPStrategy : ISeedStrategy
    {
        private readonly IConfiguration _configuration;

        public TVPStrategy(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<TimeSpan> SeedData(IEnumerable<User> users, IEnumerable<Product> products, IEnumerable<Order> orders, IEnumerable<OrderProduct> orderProducts)
        {
            var connection = _configuration.GetConnectionString("SqlConnection");

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            await SeedTVP(connection, TVPCommands.USERS_COMMAND, users);
            await SeedTVP(connection, TVPCommands.PRODUCTS_COMMAND, products);
            await SeedTVP(connection, TVPCommands.ORDERS_COMMAND, orders);
            await SeedTVP(connection, TVPCommands.ORDERPRODUCTS_COMMAND, orderProducts);

            stopWatch.Stop();
            return stopWatch.Elapsed;
        }

        private async Task SeedTVP<TData>(string connection, string commandName, IEnumerable<TData> data)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                using (SqlCommand command = new SqlCommand(commandName, sqlConnection))
                {
                    command.CommandTimeout = 360;
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter TVParam = new SqlParameter();
                    TVParam.ParameterName = "@ImportTable";
                    TVParam.Value = commandName switch
                    {
                        TVPCommands.USERS_COMMAND => TVPTypes.USERS_TYPE,
                        TVPCommands.PRODUCTS_COMMAND => TVPTypes.PRODUCTS_TYPE,
                        TVPCommands.ORDERS_COMMAND => TVPTypes.ORDERS_TYPE,
                        _ => TVPTypes.ORDERPRODUCTS_TYPE
                    };
                    TVParam.SqlDbType = SqlDbType.Structured;
                    TVParam.Value = GetTVPValue(data);
                    command.Parameters.Add(TVParam);

                    sqlConnection.Open();

                    await command.ExecuteNonQueryAsync();

                    sqlConnection.Close();
                }
            }
        }

        private IEnumerable<SqlDataRecord> GetTVPValue<TData>(IEnumerable<TData> data)
        {
            var props = typeof(TData).GetProperties().Where(x => x.PropertyType.IsEnum || !(x.PropertyType.IsGenericType 
            || x.PropertyType.Namespace == null || !x.PropertyType.Namespace.StartsWith("System"))).ToArray();

            var propsQuantity = props.Count();

            var tvpSchema = new SqlMetaData[propsQuantity];

            for(int i = 0; i < propsQuantity; i++)
            {
                if (props[i].PropertyType == typeof(DateTime))
                    tvpSchema[i] = new SqlMetaData(props[i].Name, SqlDbType.DateTime);
                else if (props[i].PropertyType == typeof(decimal))
                    tvpSchema[i] = new SqlMetaData(props[i].Name, SqlDbType.Decimal, 18, 2);
                else if(props[i].PropertyType.IsEnum)
                    tvpSchema[i] = new SqlMetaData(props[i].Name, SqlDbType.Int);
                else
                    tvpSchema[i] = new SqlMetaData(props[i].Name, SqlDbType.NVarChar, SqlMetaData.Max);
            }
            SqlDataRecord dataRecord = new SqlDataRecord(tvpSchema);

            foreach (var cell in data)
            {
                for(int i = 0; i < propsQuantity; i++)
                {
                    if (props[i].PropertyType.IsEnum)
                        dataRecord.SetInt32(i, (int)props[i].GetValue(cell));
                    else if(props[i].PropertyType == typeof(DateTime))
                        dataRecord.SetDateTime(i, (DateTime)props[i].GetValue(cell));
                    else if(props[i].PropertyType == typeof(decimal))
                        dataRecord.SetDecimal(i, (decimal)props[i].GetValue(cell));
                    else
                        dataRecord.SetString(i, props[i].GetValue(cell).ToString());
                }

                yield return dataRecord;
            }
        }
    }
}
