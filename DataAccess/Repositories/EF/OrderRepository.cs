using DataAccess.Data;
using DataAccess.Repositories.RepositoryExtensions;
using Domain.DTOs;
using Domain.DTOs.OrderInfo;
using Domain.DTOs.Product;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces.Repositories;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.EF
{
    public class OrderRepository : IOrderRepository
    {
        private readonly GridDbContext _context;

        public OrderRepository(GridDbContext context)
        {
            _context = context;
        }

        public async Task Add(OrderInfoPostDTO orderInfo)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == orderInfo.UserId);

            if(user == null)
                throw new ResponseException("Can't find this user", nameof(Add), ErrorCodes.Err404U);

            var order = new Order
            {
                Id = Guid.NewGuid(),
                Address = orderInfo.Address,
                UserId = user.Id
            };

            var orderProd = new List<OrderProduct>();
            var prodIds = orderInfo.Products.Select(x => x.ProductId);

            var products = await _context.Products
                    .AsNoTracking()
                    .Where(x => prodIds.Contains(x.Id))
                    .Select(x => new
                    {
                        Id = x.Id,
                        Price = x.Price,
                    })
                    .ToListAsync();

            if (products.Any(x => x == null))
                throw new ResponseException("Can't find this product", nameof(Add), ErrorCodes.Err404P);

            decimal totalSum = default(decimal);
            foreach (var prod in products)
            {
                orderProd.Add(new OrderProduct
                {
                    OrderId = order.Id,
                    ProductId = prod.Id
                });

                totalSum += prod.Price;
            }

            order.TotalPrice = totalSum;

            _context.Orders.Add(order);
            _context.OrdersAndProducts.AddRange(orderProd);

            var saveResult = await _context.SaveChangesAsync();

            if (saveResult == 0)
                throw new ResponseException("Something went wrong while saving entity", nameof(Add), ErrorCodes.Err500);
        }

        public async Task<PagedList<OrderInfoDTO>> GetAll(OrderInfoRequestParametersDTO parameters)
        {
            var orders = _context.Orders.Include(x => x.User)
                .Include(x => x.OrderProducts)
                .ThenInclude(x => x.Product)
                .Select(x => new OrderInfoDTO
                {
                    Id = x.Id,
                    OrderDate = x.OrderDate,
                    TotalPrice = x.TotalPrice,
                    Status = x.Status,
                    Address = x.Address,
                    FirstName = x.User.FirstName,
                    LastName = x.User.LastName,
                    Phone = x.User.Phone,
                    UserId = x.UserId,
                    Products = x.OrderProducts.Where(y => y.OrderId == x.Id).Select(y => new ProductDTO
                    {
                        Id = y.Product.Id,
                        Name = y.Product.Name,
                        Price = y.Product.Price
                    }).ToList()
                })
                .DataRange(parameters.DataRanges)
                .GlobalFilter(parameters.GlobalSearchTerm)
                .Filter(parameters.Filters)
                .Sort(parameters.OrderBy);

            var pagedList = await PagedList<OrderInfoDTO>.ToPagedListAsync(orders, parameters.PageNumber, parameters.PageSize);
            
            return pagedList;
        }

        public async Task Remove(Guid orderId)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(x => x.Id == orderId);

            if (order == null)
                throw new ResponseException("Can't find this order", nameof(Remove), ErrorCodes.Err404O);

            _context.Orders.Remove(order);

            var saveResult = await _context.SaveChangesAsync();

            if (saveResult == 0)
                throw new ResponseException("Something went wrong while saving entity", nameof(Remove), ErrorCodes.Err500);
        }

        public async Task Update(Guid id, OrderInfoUpdateDTO orderInfo)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == orderInfo.UserId);

            if(user == null)
                throw new ResponseException("Can't find this user", nameof(Update), ErrorCodes.Err404U);

            var order = await _context.Orders.FirstOrDefaultAsync(x => x.Id == id);

            if (order == null)
                throw new ResponseException("Can't find this order", nameof(Update), ErrorCodes.Err404O);

            order.OrderDate = orderInfo.OrderDate;
            order.Status = orderInfo.Status;
            order.Address = orderInfo.Address;
            order.UserId = user.Id;

            var orderProducts = await _context.OrdersAndProducts.Where(x => x.OrderId == order.Id).ToListAsync();
            _context.OrdersAndProducts.RemoveRange(orderProducts);

            var prodIds = orderInfo.Products.Select(x => x.ProductId);

            var products = await _context.Products
                            .AsNoTracking()
                            .Where(x => prodIds.Contains(x.Id))
                            .Select(x => new
                            {
                                Id = x.Id,
                                Price = x.Price,
                            })
                            .ToListAsync();

            if (products.Any(x => x == null))
                throw new ResponseException("Can't find this product", nameof(Update), ErrorCodes.Err404P);

            var newOrderProd = new List<OrderProduct>();
            decimal totalSum = default(decimal);
            foreach (var prod in products)
            {
                newOrderProd.Add(new OrderProduct
                {
                    OrderId = order.Id,
                    ProductId = prod.Id
                });

                totalSum += prod.Price;
            }

            order.TotalPrice = totalSum;

            _context.Orders.Update(order);
            _context.OrdersAndProducts.AddRange(newOrderProd);

            var saveResult = await _context.SaveChangesAsync();

            if (saveResult == 0)
                throw new ResponseException("Something went wrong while saving entity", nameof(Update), ErrorCodes.Err500);
        }
    }
}
