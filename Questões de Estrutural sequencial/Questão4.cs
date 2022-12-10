using System;
using System.Globalization;
Console.WriteLine("SALVE");

Console.WriteLine("Insira o número do funcionário:");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o número de horas trabalhadas:");
int hours = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o valor que recebe por hora:");
double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double salary = hours * value;
Console.WriteLine("NUMBER =" + num);
Console.WriteLine("SALARY = U$" + salary.ToString("F2", CultureInfo.InvariantCulture));