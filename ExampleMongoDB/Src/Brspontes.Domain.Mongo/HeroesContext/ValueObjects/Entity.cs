using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Brspontes.Domain.Mongo.HeroesContext.ValueObjects
{
    public class Entity
    {
        [BsonId()]
        public ObjectId Id { get; set; }
    }
}
