using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira as coordenadas: ");
            string[] coord = Console.ReadLine().Split(' ');
            int x = int.Parse(coord[0]);
            int y = int.Parse(coord[1]);
            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quarto");
                }
                coord = Console.ReadLine().Split(' ');
                x = int.Parse(coord[0]);
                y = int.Parse(coord[1]);
            }

        }
    }
}

