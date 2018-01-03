using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter A Number: ");
            double num = Convert.ToDouble( Console.ReadLine() );
            Console.Write("Thanks. Now Enter A Number: ");
            Char letter = Convert.ToChar(Console.ReadLine());
            if(num >= 6)
            {
                Console.WriteLine("\nNumber Exceeds 5");
                if(letter == 'c')
                {
                    Console.WriteLine("letter is 'c'");
                }
            }
            else
            {
                Console.WriteLine("\nNumber Is 5 Or Less");
            }
            Console.ReadKey();

        }
    }
}
