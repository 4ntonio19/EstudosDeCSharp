using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantidade de números: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                string[] nums = Console.ReadLine().Split(' ');
                double a = double.Parse(nums[0], CultureInfo.InvariantCulture);
                double b = double.Parse(nums[1], CultureInfo.InvariantCulture);
                double c = double.Parse(nums[2], CultureInfo.InvariantCulture);

                double media = ((a * 2) + (b * 3) + (c * 5)) / 10;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }

        }
    }
}

