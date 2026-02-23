// See https://aka.ms/new-console-template for more information
using System;

namespace DelegateLambdaDemo
{
    // Step 1: Declare Delegate
    public delegate int Operation(int a, int b);

    class Program
    {
        // Normal Method
        public static int Add(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            // Using Delegate with Normal Method
            Operation op1 = Add;
            Console.WriteLine("Addition using Normal Method: " + op1(10, 5));

            // Using Anonymous Method
            Operation op2 = delegate (int x, int y)
            {
                return x - y;
            };
            Console.WriteLine("Subtraction using Anonymous Method: " + op2(10, 5));

            // Using Lambda Expression
            Operation op3 = (x, y) => x * y;
            Console.WriteLine("Multiplication using Lambda Expression: " + op3(10, 5));

            Console.ReadLine();
        }
    }
}