using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de números:");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                string[] nums = Console.ReadLine().Split(' ');
                double a = int.Parse(nums[0], CultureInfo.InvariantCulture);
                double b = int.Parse(nums[1], CultureInfo.InvariantCulture);
                if (b != 0)
                {
                    double conta = (double)a / b;
                    Console.WriteLine(conta.ToString("F1"), CultureInfo.InvariantCulture);
                }
                else
                {
                    Console.WriteLine("Divisão impossível");
                }
            }

        }
    }
}

