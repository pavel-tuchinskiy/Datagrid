using Domain.DTOs.Product;
using Domain.Entities;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.DTOs.OrderInfo
{
    public class OrderInfoDTO
    {
        [BsonElement("_id")]
        public Guid Id { get; set; }

        [BsonElement("products")]
        public List<ProductDTO> Products { get; set; }

        [BsonElement("total_price")]
        public decimal TotalPrice { get; set; }

        [BsonElement("order_date")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime OrderDate { get; set; }

        [BsonElement("status")]
        public OrderStatus Status { get; set; }

        [BsonElement("address")]
        public string Address { get; set; }

        [BsonElement("user_id")]
        public Guid UserId { get; set; }

        [BsonElement("first_name")]
        public string FirstName { get; set; }

        [BsonElement("last_name")]
        public string LastName { get; set; }

        [BsonElement("phone")]
        public string Phone { get; set; }
    }
}
