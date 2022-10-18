using Domain.DTOs;
using Domain.DTOs.OrderInfo;
using Domain.Entities;
using Domain.Interfaces.Data;
using Domain.Interfaces.Repositories;
using Domain.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using DataAccess.Repositories.Extensions;
using Domain.Exceptions;

namespace DataAccess.Repositories.Mongo
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IGridDbMongoContext _context;
        private readonly IMongoCollection<BsonDocument> _ordersCollection;
        private readonly IMongoCollection<User> _usersCollection;
        private readonly IMongoCollection<Product> _productsCollection;

        public OrderRepository(IGridDbMongoContext context)
        {
            _context = context;
            _ordersCollection = _context.GetCollection<BsonDocument>("Orders");
            _usersCollection = _context.GetCollection<User>("Users");
            _productsCollection = _context.GetCollection<Product>("Products");
        }

        public async Task Add(OrderInfoPostDTO orderInfo)
        {
            var userFilter = Builders<User>.Filter;
            var user = await _usersCollection.Find(new BsonDocument
            {
                { "_id", new BsonDocument{ { "$eq", orderInfo.UserId.ToString() } } }
            })
                .FirstOrDefaultAsync();

            if(user == null)
                throw new ResponseException("Can't find this user", nameof(Add), ErrorCodes.Err404U);

            var prodIds = orderInfo.Products.Select(x => x.ProductId.ToString()).ToList();

            var products = await _productsCollection.Find(new BsonDocument
            {
                { "_id", new BsonDocument
                {
                    { "$in", new BsonArray().AddRange(prodIds) }
                } }
            })
                .ToListAsync();

            if (products == null)
                throw new ResponseException("Can't find required products", nameof(Add), ErrorCodes.Err404P);

            var prodArray = new BsonArray();

            foreach (var product in products)
            {
                prodArray.Add(new BsonDocument
                {
                    { "_id", product.Id.ToString() },
                    { "name", product.Name },
                    { "price", product.Price }
                });
            }

            await _ordersCollection.InsertOneAsync(new BsonDocument
            {
                { "_id", Guid.NewGuid().ToString() },
                { "order_date", DateTime.UtcNow },
                { "status", OrderStatus.Awaiting },
                { "address", orderInfo.Address },
                { "total_price", (double)products.Sum(x => x.Price) },
                { "user_id", orderInfo.UserId.ToString() },
                { "products", prodArray }
            });
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
                .Sort<OrderInfoDTO>(parameters.OrderBy);

            return await PagedList<OrderInfoDTO>.ToPagedListAsync(orders, 1, 10);
        }

        public async Task Remove(Guid orderId)
        {
            var order = await _ordersCollection.FindOneAndDeleteAsync(new BsonDocument
            {
                { "_id", new BsonDocument{ { "$eq", orderId.ToString() } } }
            });

            if(order == null)
                throw new ResponseException("Can't find this order", nameof(Remove), ErrorCodes.Err404O);
        }

        public async Task Update(Guid id, OrderInfoUpdateDTO orderInfo)
        {
            var prodIds = orderInfo.Products.Select(x => x.ProductId.ToString()).ToList();

            var products = await _productsCollection.Find(new BsonDocument
            {
                { "_id", new BsonDocument
                {
                    { "$in", new BsonArray().AddRange(prodIds) }
                } }
            })
                .ToListAsync();

            if (products == null)
                throw new ResponseException("Can't find required products", nameof(Add), ErrorCodes.Err404P);

            var prodArray = new BsonArray();

            foreach (var product in products)
            {
                prodArray.Add(new BsonDocument
                {
                    { "_id", product.Id.ToString() },
                    { "name", product.Name },
                    { "price", product.Price }
                });
            }

            var orderBefore = await _ordersCollection.FindOneAndUpdateAsync(new BsonDocument
            {
                { "_id", new BsonDocument{ { "$eq", id.ToString() } } }
            }, new BsonDocument
            {
                { "$set", new BsonDocument
                {
                    { "order_date", orderInfo.OrderDate },
                    { "status", orderInfo.Status },
                    { "address", orderInfo.Address },
                    { "user_id", orderInfo.UserId.ToString() },
                    { "products", prodArray }
                } }
            }, new FindOneAndUpdateOptions<BsonDocument> { ReturnDocument = ReturnDocument.Before});

            if(orderBefore == null)
                throw new ResponseException("Order didn't exist and was inserted.", nameof(Remove), ErrorCodes.Err404O);
        }
    }
}
