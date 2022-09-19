using Domain.DTOs.Product;

namespace Domain.DTOs.OrderInfo
{
    public class OrderInfoPostDTO
    {
        public List<ProductOrderInfoCreateUpdateDTO> Products { get; set; }
        public string Address { get; set; }
        public Guid UserId { get; set; }
    }
}
