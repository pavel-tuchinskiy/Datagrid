using Domain.DTOs;
using Domain.DTOs.Product;
using Domain.Models;

namespace Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<PagedList<ProductDTO>> GetProducts(RequestParametersDTO parameters);
        Task CreateProduct(ProductCreateDTO productDTO);
    }
}
