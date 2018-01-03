using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = new string[3] { "BMW", "Ford", "Opel" };
            int[,] corrds = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("Second Car: " + cars[1]);
            Console.WriteLine("X1,Y1: " + corrds[0,0]);
            Console.WriteLine("X2,Y3: " + corrds[1, 2]);
            Console.ReadKey();
        }
    }
}
