using System;
class TypeCasting
{
    //Implicit Casting (automatically) - converting a smaller type to a larger type size
    //char -> int -> long -> float -> double

    //Explicit Casting (manually) - converting a larger type to a smaller size type
    //double -> float -> long -> int -> char

    static void Main()
    {
        int myInt1 = 19;
        double myDouble1 = myInt1;//Automatic casting: int to double
        Console.WriteLine(myInt1);
        Console.WriteLine(myDouble1);

        int myInt = 10;
        double myDouble = 5.25;
        int myInt2 = (int) myDouble;// Manual casting: double to int
        Console.WriteLine(myInt2);
        Console.WriteLine(myDouble);
        bool myBool = true;

        Console.WriteLine(Convert.ToString(myInt));// convert int to string
        Console.WriteLine(Convert.ToDouble(myInt)); // convert int to double
        Console.WriteLine(Convert.ToInt32(myDouble));// convert double to int
        Console.WriteLine(Convert.ToString(myBool));// convert bool to string
    }
}