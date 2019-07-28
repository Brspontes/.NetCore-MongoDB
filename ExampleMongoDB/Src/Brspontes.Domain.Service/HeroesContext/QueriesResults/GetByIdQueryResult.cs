using MongoDB.Bson;

namespace Brspontes.Domain.Service.Mongo.HeroesContext.QueriesResults
{
    public class GetByIdQueryResult
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string SuperHeroName { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}
