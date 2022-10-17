using MongoDB.Bson.Serialization.Attributes;

namespace Domain.DTOs.Product
{
    public class ProductDTO
    {
        [BsonId]
        public Guid Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("price")]
        public decimal Price { get; set; }
    }
}
