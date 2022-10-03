using Bogus;
using DataAccess.Data.Seed.SeedStrategy;
using Domain.Entities;
using Microsoft.Extensions.Configuration;

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
            _productFaker = new Faker<Product>()
                .RuleFor(x => x.Name, s => s.Commerce.ProductName())
                .RuleFor(x => x.Price, s => s.Commerce.Price(100).First());

            _userFaker = new Faker<User>()
                .RuleFor(x => x.FirstName, s => s.Name.FirstName())
                .RuleFor(x => x.LastName, s => s.Name.LastName())
                .RuleFor(x => x.Phone, s => s.Phone.PhoneNumber("#######"));

            _orderFaker = new Faker<Order>()
                .RuleFor(x => x.Address, s => s.Address.FullAddress())
                .RuleFor(x => x.Status, s => s.PickRandom<OrderStatus>())
                .RuleFor(x => x.OrderDate, s => s.Date.Past(3))
                .RuleFor(x => x.TotalPrice, s => s.Commerce.Price(200, 1000).First());

            _orderProductFaker = new Faker<OrderProduct>();
            _orderProductFaker.RuleFor(x => x.Id, s => s.Database.Random.Uuid());
        }

        public async Task Initialize(GridDbContext dbContext, IConfiguration configuration)
        {
            dbContext.Database.EnsureCreated();
            var connection = configuration.GetConnectionString("SqlConnection");

            Console.WriteLine("Seed data?(y/n): ");
            var result = Console.ReadLine();

            if (result == "n")
            {
                return;
            }

            Console.WriteLine("Data generation started...");

            var productsIds = SeedHelper.GenerateIds(Constants.SEED_DATA_QUANTITY);
            var userIds = SeedHelper.GenerateIds(Constants.SEED_DATA_QUANTITY);
            var orderIds = SeedHelper.GenerateIds(Constants.SEED_DATA_QUANTITY);

            int prodIndex = 0, userIndex = 0, orderIndex = 0;

            _productFaker.RuleFor(x => x.Id, s => productsIds[prodIndex++]);
            var products = _productFaker.GenerateLazy(Constants.SEED_DATA_QUANTITY);

            _userFaker.RuleFor(x => x.Id, s => userIds[userIndex++]);
            var users = _userFaker.GenerateLazy(Constants.SEED_DATA_QUANTITY);

            _orderFaker.RuleFor(x => x.UserId, s => s.PickRandom(userIds)).RuleFor(x => x.Id, s => orderIds[orderIndex++]);

            var orders = _orderFaker.GenerateLazy(Constants.SEED_DATA_QUANTITY);

            _orderProductFaker.RuleFor(x => x.ProductId, s => s.PickRandom(productsIds))
                .RuleFor(x => x.OrderId, s => s.PickRandom(orderIds));

            var orderProducts = _orderProductFaker.GenerateLazy(Constants.SEED_DATA_QUANTITY);

            Console.WriteLine("Data generation completed");

            var resolver = new SeedGenerationResolver(dbContext, configuration);
            var strategy = resolver.GetStategy(SeedStrategies.TVP);

            dbContext.ChangeTracker.AutoDetectChangesEnabled = false;

            Console.WriteLine("Insert operation started...");

            var seedTime = await strategy.SeedData(users, products, orders, orderProducts);

            dbContext.ChangeTracker.AutoDetectChangesEnabled = true;

            var elapsedTime = SeedHelper.TimeSpanToFormatedString(seedTime);
            Console.WriteLine("Insert operation completed in " + elapsedTime);
        }
    }
}
