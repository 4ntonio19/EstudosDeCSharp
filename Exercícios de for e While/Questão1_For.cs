using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("Insira um número inteiro: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                a++;
                if (a % 2 != 0)
                {
                    Console.WriteLine(a);
                }
            }
        }
    }
}

