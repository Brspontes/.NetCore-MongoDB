using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ExampleMongoDB
{
    public class ContextConnection
    {
        public const string ConnectionString = "mongodb://localhost:27017";
        public const string DataBaseName = "Biblioteca";
        public const string CollectionName = "Livros";

        private readonly IMongoClient _client;
        private readonly IMongoDatabase _db;

        public ContextConnection()
        {
            _client = new MongoClient(ConnectionString);
            _db = _client.GetDatabase(DataBaseName);
        }

        public IMongoClient Client => _client;
        public IMongoCollection<Livro> Collection => _db.GetCollection<Livro>(CollectionName);
    }
}
