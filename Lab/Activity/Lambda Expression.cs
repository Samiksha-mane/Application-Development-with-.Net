//1. Two Examples of Lambda Expressions

//Example 1: Simple Lambda (Addition)
using System;
class Program
{
    static void Main()
    {
        Func<int, int, int> add = (a, b) => a + b;

        Console.WriteLine(add(5, 3)); // Output: 8
    }
}

//Example 2: Lambda with List (Filtering)
class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

        var evenNumbers = numbers.Where(n => n % 2 == 0);

        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
    }
}

/* 2. Where Lambda Expressions Are Used in Companies
1.LINQ Queries
2.Sorting Data
3.Event Handling
4.Task / Async Programming
5.Web APIs (Filtering, Mapping) 
*/

// 3.Create a generic class and store 2 values by using lambda expression
class Pair<T>
{
    public T Value1 { get; set; }
    public T Value2 { get; set; }

    // Lambda to display values
    public Func<T, T, string> Show = (a, b) => $"Value1: {a}, Value2: {b}";
}

class Program
{
    static void Main()
    {
        Pair<int> intPair = new Pair<int>();
        intPair.Value1 = 10;
        intPair.Value2 = 20;

        Console.WriteLine(intPair.Show(intPair.Value1, intPair.Value2));

        Pair<string> strPair = new Pair<string>();
        strPair.Value1 = "Hello";
        strPair.Value2 = "World";

        Console.WriteLine(strPair.Show(strPair.Value1, strPair.Value2));
    }
}