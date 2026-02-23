// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Activity3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 2, 8, 1, 9 };

            // Sorting using Lambda Expression
            numbers.Sort((a, b) => a.CompareTo(b));

            Console.WriteLine("Sorted List:");

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
