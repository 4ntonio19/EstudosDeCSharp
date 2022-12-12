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
            int c = 0;

            Console.WriteLine("Insira o combustível abastecido");
            int x = int.Parse(Console.ReadLine());
            while (x != 4)
            {
                if (x == 1)
                {
                    a = a + 1;
                }
                else if (x == 2)
                {
                    b = b + 1;
                }
                else if (x == 3)
                {
                    c = c + 1;
                }
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + a);
            Console.WriteLine("Gasolina: " + b);
            Console.WriteLine("Diesel: " + c);
        }
    }
}

