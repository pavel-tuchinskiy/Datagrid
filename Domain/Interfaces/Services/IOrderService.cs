using Domain.DTOs;
using Domain.DTOs.OrderInfo;
using Domain.Models;

namespace Domain.Interfaces.Services
{
    public interface IOrderService
    {
        Task Add(OrderInfoPostDTO orderInfo);
        Task<PagedList<OrderInfoDTO>> GetAll(OrderInfoRequestParametersDTO parameters);
        Task Remove(Guid orderId);
        Task Update(Guid id, OrderInfoUpdateDTO orderInfo);
    }
}
