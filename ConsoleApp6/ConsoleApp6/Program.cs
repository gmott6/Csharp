using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 10.5;
            int integer = 2;
            num = num + integer;
            Console.WriteLine("implicit cast: " + num);
            num = (double)7 / integer;
            char letter = (char)65;
            int ascii = (int)'A';
            Console.WriteLine("Cast letter: " + ascii);
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
