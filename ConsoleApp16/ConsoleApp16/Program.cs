using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Pick a Number between 1-7: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string day;
            switch(num)
            {
                case 1:day = "Monday"; break;
                case 2:day = "Tuesday"; break;
                case 3:day = "Wednesday"; break;
                case 4:day = "Thursday"; break;
                case 5:day = "Friday"; break;
                default:day = "Weekend Day"; break;
            }
            Console.WriteLine("Day " + num + ": " + day);
            Console.ReadKey();
        }
    }
}
