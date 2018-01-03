using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            sum = 1 + 4 * 3;
            Console.Write("Default Order:\t\t" + sum);
            sum = (1 + 4) * 3;
            Console.Write("\nForced Order:\t\t" + sum);
            sum = 7 - 4 + 2;
            Console.Write("\nDefault Direction:\t" + sum);
            sum = 7 - (4 + 2);
            Console.Write("\nForced Direction:\t" + sum);
            Console.ReadKey();
        }
    }
}
