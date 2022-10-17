using Domain.DTOs;
using Domain.DTOs.Product;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ReturnHttpResult> Get([FromQuery] RequestParameters parameters)
        {
            var parmetersParsed = new RequestParametersDTO()
            {
                GlobalSearchTerm = parameters.GlobalSearchTerm,
                PageNumber = parameters.PageNumber,
                PageSize = parameters.PageSize
            };

            var products = await _productService.GetProducts(parmetersParsed);

            return new ReturnHttpResult(200, products);
        }

        [HttpPost]
        public async Task<ReturnHttpResult> Post(ProductCreateDTO productCreateDTO)
        {
            await _productService.CreateProduct(productCreateDTO);

            return new ReturnHttpResult(201);
        }
    }
}
