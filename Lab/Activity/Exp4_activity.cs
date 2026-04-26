//1. Calculator using Delegate (+, -, *, /)
using System;
class Program
{
    // Delegate
    delegate int Calculator(int a, int b);

    static int Add(int a, int b) => a + b;
    static int Sub(int a, int b) => a - b;
    static int Mul(int a, int b) => a * b;
    static int Div(int a, int b) => a / b;

    static void Main()
    {
        Calculator calc;

        calc = Add;
        Console.WriteLine("Addition: " + calc(10, 5));

        calc = Sub;
        Console.WriteLine("Subtraction: " + calc(10, 5));

        calc = Mul;
        Console.WriteLine("Multiplication: " + calc(10, 5));

        calc = Div;
        Console.WriteLine("Division: " + calc(10, 5));
    }
}

//2. Multicast Delegate Example
class Program
{
    delegate void ShowMessage();

    static void Message1() => Console.WriteLine("Hello");
    static void Message2() => Console.WriteLine("Welcome");
    static void Message3() => Console.WriteLine("Good Morning");

    static void Main()
    {
        ShowMessage msg = Message1;
        msg += Message2;
        msg += Message3;

        msg(); // Calls all methods
    }
}

//3. Replace Method with Lambda Expression
Func<int, int> square = x => x * x;

Console.WriteLine(square(5)); // Output: 25

//4. Sort List using Lambda Expression
class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 2, 8, 1, 3 };

        numbers.Sort((a, b) => a.CompareTo(b));

        foreach (var n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}

/*
5. Where Delegates and Lambda are Used in Companies
Used heavily in enterprise apps built on .NET

Delegates used in: Event handling (button clicks, UI actions),Callback methods,Background processing

Lambda expressions used in:LINQ queries,Filtering and sorting data,Async programming (Task.Run(() => ...)),Web APIs (data transformation)
*/

/*6. What are LINQ Queries?
LINQ = Language Integrated Query
It allows querying data using C# syntax

-LINQ is used for:
1.Database queries (SQL-like)
2.Filtering collections
3.Sorting data
4.Joining multiple data sources
 */
