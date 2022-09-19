using Domain.DTOs.Product;
using Domain.Entities;

namespace Domain.DTOs.OrderInfo
{
    public class OrderInfoUpdateDTO
    {
        public List<ProductOrderInfoCreateUpdateDTO> Products { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public string Address { get; set; }
        public Guid UserId { get; set; }
    }
}
