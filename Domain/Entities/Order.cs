namespace Domain.Entities
{
    public enum OrderStatus
    {
        Awaiting,
        Shipping,
        Delivered,
        Refunded
    }
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string Address { get; set; }
        public decimal TotalPrice { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }
    }
}
