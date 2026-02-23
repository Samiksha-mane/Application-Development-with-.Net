// See https://aka.ms/new-console-template for more information
using System;

namespace Activity2
{
    public delegate void Notify();

    class Program
    {
        static void Main(string[] args)
        {
            Notify notify;

            // Lambda expressions added to multicast delegate
            notify = () => Console.WriteLine("Message 1");
            notify += () => Console.WriteLine("Message 2");
            notify += () => Console.WriteLine("Message 3");

            // Invoke delegate
            notify();

            Console.ReadLine();
        }
    }
}
