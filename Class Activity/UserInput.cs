class UserInput
{
    static void Main()
    {
        System.Console.Write("Enter your name :");
        string name = System.Console.ReadLine();
        System.Console.WriteLine("Name :"+name);

        Console.WriteLine("Enter your age:");//
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your age is: " + age);
        //Cannot implicitly convert type 'string' to 'int'
    }
}