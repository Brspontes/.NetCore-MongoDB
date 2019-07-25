using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMongoDB
{
    public class Handle
    {
        static void Main(string[] args)
        {
            var T = MainAsync(args);
            Console.WriteLine("Pressione Enter");
            Console.ReadLine();
        }

        static async Task MainAsync(string[] args)
        {
            var livro = new Livro();
            livro.Titulo = "Sob a Redoma";
            livro.Autor = "Stephan King";
            livro.Ano = 2012;
            livro.Paginas = 679;

            List<string> assuntos = new List<string>();
            assuntos.Add("Ficção Cientifica");
            assuntos.Add("Terror");
            assuntos.Add("Ação");

            livro.Assunto = assuntos;

            //Connection
            string connection = "mongodb://localhost:27017";
            IMongoClient client = new MongoClient(connection);

            //Database
            IMongoDatabase db = client.GetDatabase("Biblioteca");

            //Access Collection
            IMongoCollection<Livro> collection = db.GetCollection<Livro>("Livros");

            //Insert Document
            await collection.InsertOneAsync(livro);
        }
    }
}
