using Domain.DTOs.Product;
using Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using WebApi.Helpers;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productsRepository;

        public ProductsController(IProductRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        [HttpGet]
        public async Task<ReturnHttpResult> Get([FromQuery] ProductRequestParameters parameters)
        {
            var parmetersParsed = RequestParametersParser<ProductRequestParameters>.ParseParameters(parameters);
            var products = await _productsRepository.GetProducts(parmetersParsed);

            return new ReturnHttpResult(200, products);
        }

        [HttpPost]
        public async Task<ReturnHttpResult> Post(ProductCreateDTO productCreateDTO)
        {
            await _productsRepository.CreateProduct(productCreateDTO);

            return new ReturnHttpResult(201);
        }
    }
}
