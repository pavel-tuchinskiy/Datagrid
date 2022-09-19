using Domain.DTOs;
using Domain.DTOs.OrderInfo;
using Domain.Models;

namespace Domain.Interfaces.Repositories
{
    public interface IOrderRepository
    {
        Task Add(OrderInfoPostDTO orderInfo);
        Task<PagedList<OrderInfoDTO>> GetAll(RequestParametersDTO parameters);
        Task Remove(Guid orderId);
        Task Update(Guid id, OrderInfoUpdateDTO orderInfo);
    }
}
