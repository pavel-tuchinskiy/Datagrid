using Bogus;
using Domain.Entities;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace DataAccess.Data.Seed
{
    public class DbInitializer
    {
        private readonly Faker<Product> _productFaker;
        private readonly Faker<User> _userFaker;
        private readonly Faker<Order> _orderFaker;
        private readonly Faker<OrderProduct> _orderProductFaker;
        public DbInitializer()
        {
            _productFaker = new Faker<Product>();
            _productFaker.RuleFor(x => x.Id, s => Guid.NewGuid());
            _productFaker.RuleFor(x => x.Name, s => s.Commerce.ProductName());
            _productFaker.RuleFor(x => x.Price, s => s.Commerce.Price(100).First());

            _userFaker = new Faker<User>();
            _userFaker.RuleFor(x => x.Id, s => Guid.NewGuid());
            _userFaker.RuleFor(x => x.FirstName, s => s.Name.FirstName());
            _userFaker.RuleFor(x => x.LastName, s => s.Name.LastName());
            _userFaker.RuleFor(x => x.Phone, s => s.Phone.PhoneNumber("#######"));

            _orderFaker = new Faker<Order>();
            _orderFaker.RuleFor(x => x.Id, s => Guid.NewGuid());
            _orderFaker.RuleFor(x => x.Address, s => s.Address.FullAddress());
            _orderFaker.RuleFor(x => x.Status, s => s.PickRandom<OrderStatus>());
            _orderFaker.RuleFor(x => x.OrderDate, s => s.Date.Past(3));
            _orderFaker.RuleFor(x => x.TotalPrice, s => s.Commerce.Price(200, 1000).First());

            _orderProductFaker = new Faker<OrderProduct>();
            _orderProductFaker.RuleFor(x => x.Id, s => Guid.NewGuid());
        }

        public void Initialize(GridDbContext dbContext)
        {
            dbContext.Database.EnsureCreated();
            Console.WriteLine("Seed data?(y/n): ");
            var result = Console.ReadLine();

            if (result == "n") return;

            Console.WriteLine("Data generation started...");

            var products = _productFaker.Generate(Constants.SEED_DATA_QUANTITY);
            var users = _userFaker.Generate(Constants.SEED_DATA_QUANTITY);

            _orderFaker.RuleFor(x => x.UserId, s => s.PickRandom(users).Id);

            var orders = _orderFaker.Generate(Constants.SEED_DATA_QUANTITY);

            _orderProductFaker.RuleFor(x => x.ProductId, s => s.PickRandom(products).Id);
            _orderProductFaker.RuleFor(x => x.OrderId, s => s.PickRandom(orders).Id);

            var ordersProducts = _orderProductFaker.Generate(Constants.SEED_DATA_QUANTITY);

            Console.WriteLine("Data generation completed");
            Console.WriteLine("Insert operation started...");

            dbContext.ChangeTracker.AutoDetectChangesEnabled = false;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            
            dbContext.BulkInsert(products, options =>
            {
                options.TemporaryTableBatchByTable = 10;
                options.TemporaryTableBatchByTable = 100000;
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
                options.BatchSize = 100000;
            });

            dbContext.BulkInsert(users, options =>
            {
                options.TemporaryTableBatchByTable = 10;
                options.TemporaryTableBatchByTable = 100000;
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
                options.BatchSize = 100000;
            });

            dbContext.BulkInsert(orders, options =>
            {
                options.TemporaryTableBatchByTable = 10;
                options.TemporaryTableBatchByTable = 100000;
                options.TemporaryTableUseTableLock = true;
                options.UseLogDump = false;
                options.AutoMap = Z.BulkOperations.AutoMapType.ByName;
                options.AutoTruncate = false;
                options.ValidateAllDestinationMapped = false;
                options.ValidateAllSourceMapped = false;
                options.SqlBulkCopyOptions = (int)SqlBulkCopyOptions.TableLock;
                options.BatchDelayInterval = 0;
                options.DisableDotCheckForEscapeTableName = true;
                options.IsCheckConstraintOnInsertDisabled = false;
                options.DisableTemporaryTableClusteredIndex = true;
                options.DisableInformationSchemaCache = true;
                options.DisablePrimaryKeyNullCheck = true;
                options.DisableValueGenerated = true;
                options.AutoMapOutputDirection = false;
                options.InsertKeepIdentity = false;
                options.BatchSize = 100000;
            });

            dbContext.BulkInsert(ordersProducts, options =>
            {
                options.TemporaryTableBatchByTable = 10;
                options.TemporaryTableBatchByTable = 100000;
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
                options.BatchSize = 100000;
            });

            stopWatch.Stop();

            dbContext.ChangeTracker.AutoDetectChangesEnabled = false;

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("Insert operation completed in " + elapsedTime);
        }
    }
}
