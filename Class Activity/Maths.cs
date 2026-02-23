using System;
class Maths
{
    static void Main()
    {
        //The Math.Max(x,y) method can be used to find the highest value of x and y
        int maxValue = Math.Max(5, 10);
        Console.WriteLine(maxValue);

        //The Math.Min(x,y) method can be used to find the lowest value of of x and y
        int MinValue = Math.Min(56,23);
        Console.WriteLine(MinValue);

        //The Math.Sqrt(x) method returns the square root of x
        double sqr = Math.Sqrt(81);
        Console.WriteLine(sqr);

        //The Math.Abs(x) method returns the absolute (positive) value of x
        double abs = Math.Abs(-4.5);
        Console.WriteLine(abs);

        //Math.Round() rounds a number to the nearest whole number
        double roundValue = Math.Round(89.7);
        Console.WriteLine(roundValue);
        
    }
}