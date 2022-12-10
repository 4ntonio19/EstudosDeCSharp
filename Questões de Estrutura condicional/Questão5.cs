using System.Globalization;
Console.WriteLine("SALVE");

int cod, quant;
double cachquente, xsalada, xbacon, torrada, refri;

string[] cods = Console.ReadLine().Split(' ');
cod = int.Parse(cods[0]);
quant = int.Parse(cods[1]);

if (cod == 1)
{
    cachquente = quant * 4.00;
    Console.WriteLine("Total: R$ " + cachquente.ToString("F2"), CultureInfo.InvariantCulture);
}
else if (cod == 2)
{
    xsalada = quant * 4.50;
    Console.WriteLine("Total: R$ " + xsalada.ToString("F2"), CultureInfo.InvariantCulture);
}
else if (cod == 3)
{
    xbacon = quant * 5.00;
    Console.WriteLine("Total: R$ " + xbacon.ToString("F2"), CultureInfo.InvariantCulture);
}
else if (cod == 4)
{
    torrada = quant * 2.00;
    Console.WriteLine("Total: R$ " + torrada.ToString("F2"), CultureInfo.InvariantCulture);
}
else if (cod == 5)
{
    refri = quant * 1.50;
    Console.WriteLine("Total: R$ " + refri.ToString("F2"), CultureInfo.InvariantCulture);
}