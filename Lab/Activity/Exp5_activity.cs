//1. Run Program Synchronously
using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        Stopwatch sw = Stopwatch.StartNew();

        Method1();
        Method2();

        sw.Stop();
        Console.WriteLine("Total Time: " + sw.ElapsedMilliseconds + " ms");
    }

    static void Method1()
    {
        Thread.Sleep(2000);
        Console.WriteLine("Method1 Done");
    }

    static void Method2()
    {
        Thread.Sleep(2000);
        Console.WriteLine("Method2 Done");
    }
}

//2. Same Code Run Asynchronously
class Program
{
    static async Task Main()
    {
        Stopwatch sw = Stopwatch.StartNew();

        Task t1 = Method1();
        Task t2 = Method2();

        await Task.WhenAll(t1, t2);

        sw.Stop();
        Console.WriteLine("Total Time: " + sw.ElapsedMilliseconds + " ms");
    }

    static async Task Method1()
    {
        await Task.Delay(2000);
        Console.WriteLine("Method1 Done");
    }

    static async Task Method2()
    {
        await Task.Delay(2000);
        Console.WriteLine("Method2 Done");
    }
}

/* 3. Replace Thread.Sleep with Task.Delay
-Using Thread.Sleep
   Thread.Sleep(2000);
.Blocks thread 
.UI freezes
*/

//4. Create Method Returning Task
class Program
{
    static async Task Main()
    {
        await SayHello();
    }

    static async Task SayHello()
    {
        await Task.Delay(1000);
        Console.WriteLine("Hello from async method");
    }
}