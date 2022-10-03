using DataAccess.Data;
using Domain.DTOs;
using Domain.DTOs.Product;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces.Repositories;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class ProductsRepository : IProductRepository
    {
        private readonly GridDbContext _context;

        public ProductsRepository(GridDbContext context)
        {
            _context = context;
        }

        public async Task CreateProduct(ProductCreateDTO productDTO)
        {
            var product = new Product
            {
                Price = productDTO.Price,
                Name = productDTO.Name
            };

            _context.Products.Add(product);
            var saveResult = await _context.SaveChangesAsync();

            if (saveResult == 0)
                throw new ResponseException("Something went wrong while saving entity", nameof(CreateProduct), ErrorCodes.Err500);
        }

        public async Task<PagedList<ProductDTO>> GetProducts(RequestParametersDTO parameters)
        {
            if (!string.IsNullOrEmpty(parameters.GlobalSearchTerm))
            {
                var products = _context.Products.Where(x => x.Name.Contains(parameters.GlobalSearchTerm))
                .Select(x => new ProductDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price
                })
                .AsQueryable();

                var prodList = await PagedList<ProductDTO>.ToPagedListAsync(products, parameters.PageNumber, parameters.PageSize);

                if(prodList.Items.Count > 0)
                {
                    return prodList;
                }
                else
                {
                    throw new ResponseException("Can't find this user", nameof(GetProducts), ErrorCodes.Err404P);
                }
            }
            else
            {
                var products = _context.Products
                .Select(x => new ProductDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price
                })
                .AsQueryable();

                return await PagedList<ProductDTO>.ToPagedListAsync(products, parameters.PageNumber, parameters.PageSize);
            }
        }
    }
}
