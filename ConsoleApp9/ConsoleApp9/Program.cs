using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 4;
            Console.WriteLine("addition:\t:" + (a + b));
            Console.WriteLine("subtraction:\t:" + (a - b));
            Console.WriteLine("Multiplication:\t:" + (a * b));
            Console.WriteLine("division:\t:" + (a / b));
            Console.WriteLine("modulus" + (a % b));
            Console.WriteLine("\nPostfix:\t:" + (a++));
            Console.WriteLine("Postfix Result......:\t:" + a);
            Console.WriteLine("\nPrefix:\t:" + ++b);
            Console.WriteLine("Prefix Results" + b);
            Console.ReadKey();
        }
    }
}
