using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ExampleMongoDB
{
    public class ListDocuments
    {
        static void Main(string[] args)
        {
            var T = MainAsync(args);
            Console.WriteLine("Pressione Enter");
            Console.ReadLine();
        }

        static async Task MainAsync(string[] args)
        {
            var connection = new ContextConnection();
            var listBooks = await connection.Collection.Find(new BsonDocument()).ToListAsync();

            foreach (var item in listBooks)
            {
                Console.WriteLine(item.ToJson<Livro>());
            }
        }
    }
}
