using Bogus;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data.Seed
{
    internal class Seeder
    {
        private readonly Faker<Product> _productFaker;
        private readonly Faker<User> _userFaker;
        private readonly Faker<Order> _orderFaker;
        private readonly Faker<OrderProduct> _orderProductFaker;
        private readonly ModelBuilder _modelBuilder;

        public Seeder(ModelBuilder modelBuilder)
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

            _orderProductFaker = new Faker<OrderProduct>();
            _orderProductFaker.RuleFor(x => x.Id, s => Guid.NewGuid());

            _modelBuilder = modelBuilder;
        }

        public void SeedData()
        {
            var products = _productFaker.Generate(500);
            var users = _userFaker.Generate(500);

            _orderFaker.RuleFor(x => x.UserId, s => s.PickRandom(users).Id);

            var orders = _orderFaker.Generate(500);

            _orderProductFaker.RuleFor(x => x.ProductId, s => s.PickRandom(products).Id);
            _orderProductFaker.RuleFor(x => x.OrderId, s => s.PickRandom(orders).Id);

            var ordersProducts = _orderProductFaker.Generate(500);

            orders.RemoveAll(x => !ordersProducts.Any(y => y.OrderId == x.Id));

            orders.ForEach(o =>
            {
                var op = ordersProducts.Where(x => x.OrderId == o.Id).Select(x => x.ProductId);
                var prod = products.Where(x => op.Contains(x.Id)).Select(x => x.Price);
                o.TotalPrice = prod.Sum();
            });

            _modelBuilder.Entity<Product>().HasData(products);
            _modelBuilder.Entity<User>().HasData(users);
            _modelBuilder.Entity<OrderProduct>().HasData(ordersProducts);
            _modelBuilder.Entity<Order>().HasData(orders);
        }
    }
}
