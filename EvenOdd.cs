class EvenOdd
{
    public static void Main()
    {
        System.Console.Write("Enter a Number :");
        int num = int.Parse(System.Console.ReadLine());
        
        if(num % 2 == 0)
        {
            System.Console.WriteLine("Even Number!");
        }
        else
        {
            System.Console.WriteLine("Odd Number!");
        }
        
    }
}