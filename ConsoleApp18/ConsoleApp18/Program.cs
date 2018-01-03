using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 4; i++)
            {
                Console.WriteLine("loop iteration" + i);
                for(int j = 1; j < 4; j++)
                {
                    Console.WriteLine("\tInner Loop Iteration" + j);
                }
            }
            Console.ReadKey();
        }
    }
}
