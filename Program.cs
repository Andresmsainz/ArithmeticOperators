using System;

namespace ArithmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arithmetic Operators!");

            int x = 6;
            int y = 2;
            int result = 0;

            //Adding
            result = (x + y);
            Console.WriteLine("Add: " + x + " + " + y + " = " + result);

            //Subtraction
            result = (x - y);
            Console.WriteLine("Subtract: " + x + " - " + y + " = " + result);

            //Multiply
            result = (x * y);
            Console.WriteLine("Multiply: " + x + " * " + y + " = " + result);

            //Divide
            result = (x / y);
            Console.WriteLine("Divide: " + x + " / " + y + " = " + result);

            //Remainder
            result = (x % y);
            Console.WriteLine("Remainder: " + x + " % " + y + " = " + result);

            x = 5;
            result = (x % y);
            Console.WriteLine("Remainder: " + x + " % " + y + " = " + result);


            Console.WriteLine("Arithmetic Challenge!");

            //x = 5;
            //y = 2;

            Console.WriteLine("Enter No. 1");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter No. 2");
            y = int.Parse(Console.ReadLine());

            result = 0;

            //Addition
            result = (x + y);
            Console.WriteLine("Addition: " + x + " + " + y + " = " + result);

            //Subtraction
            result = (x - y);
            Console.WriteLine("Subtraction: " + x + " - " + y + " = " + result);

            //Multiplication
            result = (x * y);
            Console.WriteLine("Multiplication: " + x + " * " + y + " = " + result);

            //Division (Decimal)
            Decimal decimalResult = decimal.Divide(x, y);
            Console.WriteLine("Division: " + x + " / " + y + " = " + decimalResult);

            //Remainder
            result = (x % y);
            Console.WriteLine("REmainder: " + x + " % " + y + " = " + result);


        }
    }
}
