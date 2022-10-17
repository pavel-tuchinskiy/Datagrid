using Domain.DTOs;
using Domain.DTOs.OrderInfo;
using Domain.Entities;
using Domain.Interfaces.Data;
using Domain.Interfaces.Repositories;
using Domain.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using DataAccess.Repositories.Extensions;

namespace DataAccess.Repositories.Mongo
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IGridDbMongoContext _context;
        private readonly IMongoCollection<Order> _ordersCollection;
        private readonly IMongoCollection<User> _usersCollection;
        private readonly IMongoCollection<Product> _productsCollection;

        public OrderRepository(IGridDbMongoContext context)
        {
            _context = context;
            _ordersCollection = _context.GetCollection<Order>("Orders");
            _usersCollection = _context.GetCollection<User>("Users");
            _productsCollection = _context.GetCollection<Product>("Products");
        }

        public Task Add(OrderInfoPostDTO orderInfo)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedList<OrderInfoDTO>> GetAll(OrderInfoRequestParametersDTO parameters)
        {
            var orders = _ordersCollection.Aggregate()
                .Lookup("Users", "user_id", "_id", "user")
                .Unwind("user")
                .ReplaceRoot<dynamic>(new BsonDocument
                {
                    { "$mergeObjects", new BsonArray{ "$user", "$$ROOT"} }
                })
                .Project(new BsonDocument
                {
                    { "user", 0 }
                })
                .As<OrderInfoDTO>()
                .DataRange(parameters.DataRanges)
                .GlobalFilter(parameters.GlobalSearchTerm)
                .Filter(parameters.Filters)
                .Sort<OrderInfoDTO>(parameters.OrderBy)
                .ToList();

            foreach (var order in orders)
                Console.WriteLine($"{order.Id}, {order.OrderDate}, {order.FirstName}, {order.LastName}, {order.Status}, {order.Products[0].Name}, {order.Products[0].Price}");

            return await PagedList<OrderInfoDTO>.ToPagedListAsync(new List<OrderInfoDTO>().AsQueryable(), 1, 10);
        }

        private BsonDocument GetFilterCondition<TEntity>(List<Filter> filters)
        {
            
            return new BsonDocument { 
                { "first_name", new BsonDocument { { "$regex", "lcie" }, { "$options", "i" } } },
                { "address", new BsonDocument { { "$regex", "Elgar Alley" }, { "$options", "i" } } }
            };
        }

        public Task Remove(Guid orderId)
        {
            throw new NotImplementedException();
        }

        public Task Update(Guid id, OrderInfoUpdateDTO orderInfo)
        {
            throw new NotImplementedException();
        }
    }
}
