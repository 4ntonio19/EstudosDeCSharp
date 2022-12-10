using System.Globalization;
Console.WriteLine("SALVE");
double x, y;
Console.WriteLine("Insira dois valores decimais:");
string[] valores = Console.ReadLine().Split(' ');
x = double.Parse(valores[0]);
y = double.Parse(valores[1]);
if (x == 0 && y == 0)
{
    Console.WriteLine("Origem");
}
else if (y == 0)
{
    Console.WriteLine("Eixo X");
}
else if (x == 0)
{
    Console.WriteLine("Eixo Y");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("Q1");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Q2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Q3");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Q4");
}
