using Domain.DTOs;
using Domain.DTOs.Product;
using Domain.Models;

namespace Domain.Interfaces.Services
{
    public interface IProductService
    {
        Task<PagedList<ProductDTO>> GetProducts(RequestParametersDTO parameters);
        Task CreateProduct(ProductCreateDTO productDTO);
    }
}
