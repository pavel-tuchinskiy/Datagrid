using Domain.DTOs;
using Domain.DTOs.Product;
using Domain.Entities;
using Domain.Interfaces.Data;
using Domain.Interfaces.Repositories;
using Domain.Models;
using MongoDB.Driver;

namespace DataAccess.Repositories.Mongo
{
    public class ProductsRepository : IProductRepository
    {
        private readonly IGridDbMongoContext _context;
        private readonly IMongoCollection<Product> _productsCollection;

        public ProductsRepository(IGridDbMongoContext context)
        {
            _context = context;
            _productsCollection = _context.GetCollection<Product>("Products");
        }

        public async Task CreateProduct(ProductCreateDTO productDTO)
        {
            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = productDTO.Name,
                Price = productDTO.Price
            };

            await _productsCollection.InsertOneAsync(product);
        }

        public async Task<PagedList<ProductDTO>> GetProducts(RequestParametersDTO parameters)
        {
            var projection = Builders<Product>.Projection.Expression(p => new ProductDTO
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price
            });

            FilterDefinition<Product> filter = null;

            if (!string.IsNullOrEmpty(parameters.GlobalSearchTerm))
                filter = Builders<Product>.Filter.Where(u => u.Name.Contains(parameters.GlobalSearchTerm));
            else
                filter = Builders<Product>.Filter.Empty;

            var products = _productsCollection.Find(filter).Project(projection);

            return await PagedList<ProductDTO>.ToPagedListAsync<Product, ProductDTO>(products, parameters.PageNumber, parameters.PageSize);
        }
    }
}
