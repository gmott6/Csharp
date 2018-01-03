using System;

namespace ConsoleApp8
{
    class Program

    {
        enum Days { Sat, Sun, Mon, Tue, Wed, Thu, Fri};
        static void Main(string[] args)
        {
            const double pi = 3.14159265358979;
            var daysType = typeof(Days);
            Console.WriteLine("Pi Type: " + pi.GetType() );
            Console.WriteLine("Circumference: " + (pi * 3) );
            string name = Enum.GetName(daysType, 1);
            Console.WriteLine("\n2nd Index: " + name);
            bool flag = Enum.IsDefined(daysType, "Mon");
            Console.WriteLine("contains Mon?: " + flag);
            Console.ReadKey();
        }
    }
}
