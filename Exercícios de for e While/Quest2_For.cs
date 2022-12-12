using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("Quantos números interiros vc quer?:");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                int y = int.Parse(Console.ReadLine());
                if (y >= 10 && y <= 20)
                {
                    a++;
                }
                else
                {
                    b++;
                }
            }
            Console.WriteLine(a + " in");
            Console.WriteLine(b + " out");
        }
    }
}

