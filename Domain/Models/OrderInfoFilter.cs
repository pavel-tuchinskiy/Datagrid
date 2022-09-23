using Domain.Entities;

namespace Domain.DTOs
{
    public class OrderInfoFilter
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public decimal? TotalPrice { get; set; }
        public DateTime? OrderDate { get; set; }
        public OrderStatus? Status { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public ProductFilter? Products { get; set; }
    }
}
