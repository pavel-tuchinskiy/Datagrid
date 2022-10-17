using DataAccess.Data;
using DataAccess.Repositories;
using Domain.DTOs;
using Domain.DTOs.OrderInfo;
using Domain.Interfaces.Data;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Models;

namespace Services.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(GridDbContext efContext, IGridDbMongoContext mongoContext)
        {
            var resolver = new RepositoryResolver(efContext, mongoContext);
            _orderRepository = resolver.GetOrderRepository(RepositoryProviders.Mongo);
        }

        public async Task Add(OrderInfoPostDTO orderInfo)
        {
            await _orderRepository.Add(orderInfo);
        }

        public async Task<PagedList<OrderInfoDTO>> GetAll(OrderInfoRequestParametersDTO parameters)
        {
            var orders = await _orderRepository.GetAll(parameters);

            return orders;
        }

        public async Task Remove(Guid orderId)
        {
            await _orderRepository.Remove(orderId);
        }

        public async Task Update(Guid id, OrderInfoUpdateDTO orderInfo)
        {
            await _orderRepository.Update(id, orderInfo);
        }
    }
}
