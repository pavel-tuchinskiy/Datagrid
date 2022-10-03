using Domain.Entities;

namespace DataAccess.Data.Seed.SeedStrategy
{
    public interface ISeedStrategy
    {
        Task<TimeSpan> SeedData(IEnumerable<User> users, IEnumerable<Product> products, IEnumerable<Order> orders, IEnumerable<OrderProduct> orderProducts);
    }
}
