using Domain.Interfaces.Data;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class GridDbMongoContext : IGridDbMongoContext
    {
        private readonly IMongoClient _mongoClient;
        private readonly IMongoDatabase _database;

        public GridDbMongoContext(IMongoClient mongoClient, IConfiguration configuration)
        {
            _mongoClient = mongoClient;
            var dbName = configuration.GetSection("DatabaseName").Value;
            _database = _mongoClient.GetDatabase(dbName);
        }

        public IMongoCollection<TData> GetCollection<TData>(string name)
        {
            return _database.GetCollection<TData>(name);
        }
    }
}
