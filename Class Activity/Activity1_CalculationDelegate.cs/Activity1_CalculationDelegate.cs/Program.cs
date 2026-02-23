// See https://aka.ms/new-console-template for more information
using System;

namespace Activity1
{
    // Delegate Declaration
    public delegate int Calculator(int a, int b);

    class Program
    {
        static int Add(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Calculator calc = Add;

            int result = calc(10, 5);

            Console.WriteLine("Addition Result: " + result);

            Console.ReadLine();
        }
    }
}