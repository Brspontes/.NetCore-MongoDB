using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMongoDB
{
    public class HandleExternalClass
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
            livro.Titulo = "Sob a Redoma 2";
            livro.Autor = "Stephan King";
            livro.Ano = 2012;
            livro.Paginas = 679;

            List<string> assuntos = new List<string>();
            assuntos.Add("Ficção Cientifica 2");
            assuntos.Add("Terror 2");
            assuntos.Add("Ação 2");

            livro.Assunto = assuntos;

            var connection = new ContextConnection();


            //Insert Document
            await connection.Collection.InsertOneAsync(livro);
        }
    }
}
