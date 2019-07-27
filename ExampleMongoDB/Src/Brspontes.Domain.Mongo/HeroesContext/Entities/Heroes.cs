using Brspontes.Domain.Mongo.HeroesContext.ValueObjects;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Brspontes.Domain.Mongo.HeroesContext.Entities
{
    public class Heroes : Entity
    {
        public Heroes(ObjectId id, string name, string superHeroName, string image, string description)
        {
            Id = id;
            Name = name;
            SuperHeroName = superHeroName;
            Image = image;
            Description = description;
        }

        [BsonElement("nome")]
        public string Name { get; set; }

        [BsonElement("superheroname")]
        public string SuperHeroName { get; set; }

        [BsonElement("image")]
        public string Image { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }
    }
}
