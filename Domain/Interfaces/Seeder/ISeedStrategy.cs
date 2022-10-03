using Domain.Entities;

namespace Domain.Interfaces.Seeder
{
    public interface ISeedStrategy
    {
        Task<TimeSpan> SeedData(IEnumerable<User> users, IEnumerable<Product> products, IEnumerable<Order> orders, IEnumerable<OrderProduct> orderProducts);
    }
}
