using Domain.DTOs.Product;
using Domain.Entities;

namespace Domain.DTOs.OrderInfo
{
    public class OrderInfoDTO
    {
        public Guid Id { get; set; }
        public List<ProductDTO> Products { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public string Address { get; set; }
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
    }
}
