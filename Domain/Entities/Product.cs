using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Entities
{
    public class Product
    {
        [BsonId]
        public Guid Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("price")]
        public decimal Price { get; set; }
    }
}
