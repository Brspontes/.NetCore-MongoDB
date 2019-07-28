using Brspontes.Domain.Mongo.HeroesContext.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes.Infra.Mongo.MongoContext
{
    public class RepositoryConnection
    {
        private readonly IMongoClient _client;
        private readonly IMongoDatabase _db;
        public IMongoCollection<Heroes> _collection => _db.GetCollection<Heroes>("Heroes");

        public RepositoryConnection()
        {
            _client = new MongoClient("mongodb://localhost:27017");
            _db = _client.GetDatabase("DBHeroes");
        }
    }
}
