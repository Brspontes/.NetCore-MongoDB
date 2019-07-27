using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ExampleMongoDB
{
    class ListDocumentsWithDocumentBson
    {
        static void Main(string[] args)
        {
            var T = MainAsync(args);
            Console.WriteLine("Pressione Enter");
            Console.ReadLine();
        }

        static async Task MainAsync(string[] args)
        {
            var filtro = new BsonDocument
            {
                {"Autor" , "Machados de Assis" }
            };

            var connection = new ContextConnection();
            var listBooks = await connection.Collection.Find(new BsonDocument()).ToListAsync(); //GET ALL
            var listBooksFilter = await connection.Collection.Find(filtro).ToListAsync(); //GET FILTER

            foreach (var item in listBooks)
            {
                Console.WriteLine(item.ToJson<Livro>());
            }

            //GET Another FILTER Autor
            var construtor = Builders<Livro>.Filter;
            var condicao = construtor.Eq(x => x.Autor, "Machado de Assis");
            var listBooksFilter2 = await connection.Collection.Find(filtro).ToListAsync();

            //GET Another FILTER Ano >= 1999
            condicao = construtor.Gte(x => x.Ano, 1999);
            listBooksFilter2 = await connection.Collection.Find(filtro).ToListAsync();

            //GET Another FILTER Ano >= 1999 e mais de 300 paginas
            condicao = construtor.Gte(x => x.Ano, 1999) & construtor.Gte(x => x.Paginas, 300);
            listBooksFilter2 = await connection.Collection.Find(filtro).ToListAsync();

            //GET Another FILTER Assunto = Ficção
            condicao = construtor.AnyEq(x => x.Assunto, "Ficção Cientifica");
            listBooksFilter2 = await connection.Collection.Find(filtro).ToListAsync();

            //REALIZAR UPDATE
            //connection.Collection.ReplaceOneAsync(condicao, valor);

            var construtorAlteracao = Builders<Livro>.Update;
            var condicaoAlteracao = construtorAlteracao.Set(x => x.Ano, 2001);
            await connection.Collection.UpdateOneAsync(condicao, condicaoAlteracao);



        }
    }
}
