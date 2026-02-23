// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class Program
    {
        public static async Task Task1()
        {
            Console.WriteLine("Task1 starting");
            await Task.Delay(3000);   // replaced Thread.Sleep
            Console.WriteLine("Task1 execute");
        }

        public static async Task Task2()
        {
            Console.WriteLine("Task2 starting");
            await Task.Delay(3000);
            Console.WriteLine("Task2 execute");
        }

        public static async Task Task3()
        {
            Console.WriteLine("Task3 starting");
            await Task.Delay(3000);
            Console.WriteLine("Task3 execute");
        }

        public static async Task Task4()
        {
            Console.WriteLine("Task4 starting");
            await Task.Delay(3000);
            Console.WriteLine("Task4 execute");
        }

        public static async Task Task5()
        {
            Console.WriteLine("Task5 starting");
            await Task.Delay(3000);
            Console.WriteLine("Task5 execute");
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("Async Parallel Started");

            await Task.WhenAll(
                Task1(),
                Task2(),
                Task3(),
                Task4(),
                Task5()
            );

            Console.WriteLine("Finished");
        }
    }
}
