using System;
using System.Globalization;
using System.Net;
using System.Numerics;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(' ');

            int n = int.Parse(num[0]);
            int m = int.Parse(num[1]);

            int[,] matriz = new int[n, m];

            for(int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                for(int j = 0; j < m; j++) 
                {
                    matriz[i, j] = int.Parse(vet[j]);
                }
            }
            int x = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine("Position: " + i + ", " + j );
                    }
                    if(j > 0)
                    {
                        Console.WriteLine("Left: " + matriz[0, j -1]);
                    }
                    if(i > 0)
                    {
                        Console.WriteLine("up: " + matriz[i - 1, j]);
                    } 
                    if(j < m -1)
                    {
                        Console.WriteLine("Right: " + matriz[i, j +1]);
                    }
                   
                    if(j < n - 1)
                    {
                        Console.WriteLine("Down: " + matriz[i +1, j]);
                    }
                }
            }   
        }
    }
}