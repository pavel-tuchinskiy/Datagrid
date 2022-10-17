using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Entities
{
    public class User
    {
        [BsonId]
        public Guid Id { get; set; }

        [BsonElement("first_name")]
        public string FirstName { get; set; }

        [BsonElement("last_name")]
        public string LastName { get; set; }

        [BsonElement("phone")]
        public string Phone { get; set; }

        public List<Order> Orders { get; set; }
    }
}
