using Brspontes.Domain.Mongo.HeroesContext.Entities;
using Brspontes.Domain.Service.Mongo.HeroesContext.Commands.Outputs;
using Brspontes.Domain.Service.Mongo.HeroesContext.Contract;
using Brspontes.Infra.Mongo.MongoContext;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Brspontes.Infra.Mongo.Repository
{
    public class HeroesRepository : IRepository
    {
        private readonly RepositoryConnection _connection;

        public HeroesRepository(RepositoryConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Heroes> Get() =>
            _connection._collection.Find(new BsonDocument()).ToList();

        public Heroes Get(ObjectId id) =>
            _connection._collection.Find(Builders<Heroes>.Filter.Eq(x => x.Id, id)).FirstOrDefault();

        public DeleteHeroCommandResult Remove(ObjectId id)
        {
            var test = _connection._collection.FindOneAndDelete(Builders<Heroes>.Filter.Eq(x => x.Id, id));
            return new DeleteHeroCommandResult
            {
                Message = "Delete sucessuful",
                Sucess = true
            };
        }

        public RegisterHeroCommandResult Save(Heroes hero)
        {
            _connection._collection.InsertOne(hero);
            return new RegisterHeroCommandResult { Message = "Register Sucessuful", Sucess = true };
        }

        public UpdateHeroCommandResult Update(Heroes hero)
        {
            var test = _connection._collection.ReplaceOne(Builders<Heroes>.Filter.Eq(x => x.Id, hero.Id), hero);
            return new UpdateHeroCommandResult { Message = "Update Sucessuful", Sucess = true };
        }
    }
}
