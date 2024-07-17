using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities
{
    public class ProductImage
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string ProductImageID { get; set; }

        public string ProductID { get; set; }

        public string Image1Url { get; set; }
        public string Image2Url { get; set;}
        public string Image3Url { get; set; }

        [BsonIgnore]
        public Product Product { get; set; }
    }
}
