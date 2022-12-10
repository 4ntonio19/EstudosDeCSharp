using System.Globalization;
Console.WriteLine("SALVE");

string[] horas = Console.ReadLine().Split(' ');

int x = int.Parse(horas[0]);
int y = int.Parse(horas[1]);
int madruga;
if (x < y)
{
    madruga = y - x;
    Console.WriteLine("O JOGO DUROU " + madruga + " HORA(S)");
}
else
{
    int meia = 24 - x;
    madruga = meia + y;
}

Console.WriteLine("O JOGO DUROU " + madruga + " HORA(S)");

