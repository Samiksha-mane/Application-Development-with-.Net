 class Operators
{ 
    static void Main()
    {
        int num1 = 10;
        int num2 = 20;

        //Arithmetic OPerator 
        System.Console.WriteLine("Addition :"+(num1+num2));
        System.Console.WriteLine("Subtraction :"+(num1-num2));
        System.Console.WriteLine("Multipocation :"+(num1*num2));
        System.Console.WriteLine("Divison :"+(num1/num2));
        System.Console.WriteLine("Modulus :"+(num1%num2));

        //Assignment Operator
        int x = 25;
        System.Console.WriteLine(x);

         //Comparaion Operator
         System.Console.WriteLine(num1 > num2);
         System.Console.WriteLine(num1 < num2);
         System.Console.WriteLine(num1 >= num2);
         System.Console.WriteLine(num1 <= num2);
         System.Console.WriteLine(num1 == num2);

         //Logical Operator 
         System.Console.WriteLine(x < 5 &&  x < 10);
         System.Console.WriteLine(x < 5 || x < 4);
         System.Console.WriteLine(!(x < 5 && x < 10));
    }
}