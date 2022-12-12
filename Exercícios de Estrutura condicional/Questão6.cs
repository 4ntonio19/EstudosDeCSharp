using System.Globalization;
Console.WriteLine("SALVE");

Console.WriteLine("Insira os valores de A, B e C:");

string[] valores = Console.ReadLine().Split(' ');

double a = double.Parse(valores[0], CultureInfo.InvariantCulture);

double b = double.Parse(valores[1], CultureInfo.InvariantCulture);

double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

double pi = 3.14159;

double areaTri = (a * c) / 2;
double areaCir = pi * (c * c);
double areaTra = (a + b) * c / 2;
double areaQua = b * b;
double areaRet = a * b;

Console.WriteLine("TRIANGULO: " + areaTri.ToString("F3"), CultureInfo.InvariantCulture);
Console.WriteLine("CIRCULO: " + areaCir.ToString("F3"), CultureInfo.InvariantCulture);
Console.WriteLine("TRAPEZIO: " + areaTra.ToString("F3"), CultureInfo.InvariantCulture);
Console.WriteLine("QUADRADO: " + areaQua.ToString("F3"), CultureInfo.InvariantCulture);
Console.WriteLine("RETANGULO: " + areaRet.ToString("F3"), CultureInfo.InvariantCulture);



