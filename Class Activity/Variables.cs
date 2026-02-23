// int - stores integers (whole numbers), without decimals, such as 123 or -123
//double - stores floating point numbers, with decimals, such as 19.99 or -19.99
//char - stores single characters, such as 'a' or 'B'. 
//Char values are surrounded by single quotes
//string - stores text, such as "Hello World". 
//String values are surrounded by double quotes
//bool - stores values with two states: true or false

class Variables
{               
    static void Main()
    {
        int num = 100;
        System.Console.WriteLine("Integer :"+num);

        double no = 34.5;
        System.Console.WriteLine("Double :"+no);

        char ch = 's';
        System.Console.WriteLine("Char :"+ch);

        string str = "Samiksha";
        System.Console.WriteLine("String :"+str);

        bool x = true;
        System.Console.WriteLine("boolean :"+x);

    //const  means unchangeable and read-only
        const int myNum = 15;
        myNum = 20; // error
    //You cannot declare a constant variable without assigning the value. 

    }
}