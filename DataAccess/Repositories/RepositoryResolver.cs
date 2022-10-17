using DataAccess.Data;
using Domain.Interfaces.Data;
using Domain.Interfaces.Repositories;

namespace DataAccess.Repositories
{
    public class RepositoryResolver
    {
        private readonly GridDbContext _efContext;
        private readonly IGridDbMongoContext _mongoContext;

        public RepositoryResolver(GridDbContext efContext, IGridDbMongoContext mongoContext)
        {
            _efContext = efContext;
            _mongoContext = mongoContext;
        }

        public IUserRepository GetUserRepository(RepositoryProviders repositoryProvider)
        {
            if (repositoryProvider == RepositoryProviders.EF)
                return new DataAccess.Repositories.EF.UsersRepository(_efContext);
            else if(repositoryProvider == RepositoryProviders.Mongo)
                return new DataAccess.Repositories.Mongo.UsersRepository(_mongoContext);
            else
                return null;
        }

        public IProductRepository GetProductRepository(RepositoryProviders repositoryProvider)
        {
            if (repositoryProvider == RepositoryProviders.EF)
                return new DataAccess.Repositories.EF.ProductsRepository(_efContext);
            else if (repositoryProvider == RepositoryProviders.Mongo)
                return new DataAccess.Repositories.Mongo.ProductsRepository(_mongoContext);
            else
                return null;
        }

        public IOrderRepository GetOrderRepository(RepositoryProviders repositoryProviders)
        {
            if (repositoryProviders == RepositoryProviders.EF)
                return new DataAccess.Repositories.EF.OrderRepository(_efContext);
            else if (repositoryProviders == RepositoryProviders.Mongo)
                return new DataAccess.Repositories.Mongo.OrderRepository(_mongoContext);
            else
                return null;
        }
    }
}
