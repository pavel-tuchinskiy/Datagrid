using MongoDB.Driver;

namespace Domain.Interfaces.Data
{
    public interface IGridDbMongoContext
    {
        IMongoCollection<TData> GetCollection<TData>(string name);
    }
}
