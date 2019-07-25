using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMongoDB
{
    class AcessarMongoDB
    {
        static void Main(string[] args)
        {
            var T = MainAsync(args);
            Console.WriteLine("Pressione Enter");
            Console.ReadLine();
        }

        static async Task MainAsync(string[] args)
        {
            var doc = new BsonDocument
            {
                {"Titulo", "Guerra dos Tronos" }
            };

            doc.Add("Autor", "Jorge R R Martin");
            doc.Add("Ano", 1993);
            doc.Add("Paginas", 856);

            var assuntoArray = new BsonArray();
            assuntoArray.Add("Fantasia");
            assuntoArray.Add("Ação");

            doc.Add("Assunto", assuntoArray);

            Console.WriteLine(doc);

            //Connection
            string connection = "mongodb://localhost:27017";
            IMongoClient client = new MongoClient(connection);

            //Database
            IMongoDatabase db = client.GetDatabase("Biblioteca");

            //Access Collection
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("Livros");

            //Insert Document
            await collection.InsertOneAsync(doc);
        }
    }
}
