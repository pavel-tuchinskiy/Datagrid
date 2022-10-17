using MongoDB.Bson.Serialization.Attributes;

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
        [BsonId]
        public Guid Id { get; set; }

        [BsonElement("order_date")]
        public DateTime OrderDate { get; set; }

        [BsonElement("status")]
        public OrderStatus Status { get; set; }

        [BsonElement("user_id")]
        public Guid UserId { get; set; }

        public User User { get; set; }

        [BsonElement("address")]
        public string Address { get; set; }

        [BsonElement("total_price")]
        public decimal TotalPrice { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }
    }
}
