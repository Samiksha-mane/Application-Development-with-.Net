using System;
class StringMethods
{
    static void Main()
    {
        String a = "Sam ";
        String b = "Mane";
        //If you add two strings, the result will be a string concatenation
        Console.WriteLine(string.Concat(a+b));  

        String x = "10";
        String y = "20";
        //If you add two strings, the result will be a string concatenation:
        Console.WriteLine(string.Concat(x+y));

        //string interpolation = substitutes values of variables into placeholders in a string. 
       string firstName = "Samiksha";
        string lastName = "Mane";
        string name = string.Format("My full name is: {0} {1}", firstName, lastName);
        Console.WriteLine(name);


        //prints the first character in myString:
        string myString = "Hello";
        Console.WriteLine(myString[0]);

        // the index position of a specific character in a string, by using the IndexOf() method
        string myString = "Hello";
        Console.WriteLine(myString.IndexOf("e"));
        
        //Substring()= extracts the characters from a string
        String lastName = name.Substring(charPos + 1);
        Console.WriteLine(lastName);


    }
}