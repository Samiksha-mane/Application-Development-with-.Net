// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

//syanchronus programming == task excute one after another
//each task wait for privous task to finish blocking behaviour 
//start -> task1 -> task2 -> task3 -> end
//perfomance is slow

// Asyanchronous programming == task can run without blocking the main thread while waiting for 1 task other task can excute
//improve responsivenes

//keywords uesd to decalre achnchonus methond allows is await inside the menthod
//ex ==> public async myMethod()

//await ==> used to wait for task to complete does not block the thread 
//ex ==> await Task.Run(()=>{ });

namespace async
    {
    class Async
    {
        public async static Task Task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task1 starting");
                Thread.Sleep(3000);
                Console.WriteLine("Task1 execute");
            });
        }
        public async static Task Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task2 starting");
                Thread.Sleep(3000);
                Console.WriteLine("Task2 execute");
            });
        }
        public async static Task Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task3 starting");
                Thread.Sleep(3000);
                Console.WriteLine("Task3 execute");
            });
        }
        public async static Task Task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task4 starting");
                Thread.Sleep(3000);
                Console.WriteLine("Task4 execute");
            });
        }
        public async static Task Task5()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task5 starting");
                Thread.Sleep(3000);
                Console.WriteLine("Task5 execute");
            });
        }
        public static async Task Main(string[] args)
        {
            Async.Task1();
            Async.Task2();
            Async.Task3();
            Async.Task4();
            Async.Task5();

            await Task1();
            await Task2();
            await Task3();
            await Task4();
            await Task5();

            Console.ReadLine();

        }
    }
}
    //1.run program snychronous
    //2.concvert to asnychro
    //3.replace thread.sleep with task.delay ==>observe behavour
    //4.creat method returning task
