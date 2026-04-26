//1. Two Examples of Generics

//Example 1: Generic Class
using System;
class Box<T>
{
    public T Value;

    public void Display()
    {
        Console.WriteLine(Value);
    }
}

class Program
{
    static void Main()
    {
        Box<int> intBox = new Box<int>();
        intBox.Value = 100;
        intBox.Display();

        Box<string> strBox = new Box<string>();
        strBox.Value = "Hello Generics";
        strBox.Display();
    }
}

//Example 2: Generic Method
class Program
{
    static void PrintData<T>(T data)
    {
        Console.WriteLine(data);
    }

    static void Main()
    {
        PrintData<int>(10);
        PrintData<string>("Welcome");
        PrintData<double>(3.14);
    }
}

//2. Real time use of generics

//Storing student records → List<Student>
//API responses → Response<T>
//Database operations → Repository<T>
//Stack, Queue → Stack<T>, Queue<T>
//Used in:Banking apps,E-commerce systems,Web APIs,Data processing systems

//3. Why Companies Use Generics

// 1. Type Safety = Prevents runtime errors
// 2. Code Reusability = One code works for multiple data types
// 3. Performance = No need for boxing/unboxing (faster execution)
// 4. Clean & Maintainable Code = Easier to read and manage large projects
// 5. Scalability = Useful in large enterprise applications



