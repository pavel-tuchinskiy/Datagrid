using DataAccess.Data;
using DataAccess.Repositories;
using Domain.DTOs;
using Domain.DTOs.Product;
using Domain.Interfaces.Data;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Models;

namespace Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(GridDbContext efContext, IGridDbMongoContext mongoContext)
        {
            var resolver = new RepositoryResolver(efContext, mongoContext);
            _productRepository = resolver.GetProductRepository(RepositoryProviders.Mongo);
        }

        public async Task CreateProduct(ProductCreateDTO productDTO)
        {
            await _productRepository.CreateProduct(productDTO);
        }

        public async Task<PagedList<ProductDTO>> GetProducts(RequestParametersDTO parameters)
        {
            var products = await _productRepository.GetProducts(parameters);

            return products;
        }
    }
}
