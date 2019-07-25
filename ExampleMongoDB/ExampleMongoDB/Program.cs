using System;

namespace ExampleMongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            MainSync(args);
            Console.WriteLine("Pressione Enter");
            Console.ReadLine();
        }

        static void MainSync(string[] args)
        {
            Console.WriteLine("Esperando 10 Segundos");
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine("Esperei 10 Segundos");
        }
    }
}
