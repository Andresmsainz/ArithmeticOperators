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
        }
    }
}
