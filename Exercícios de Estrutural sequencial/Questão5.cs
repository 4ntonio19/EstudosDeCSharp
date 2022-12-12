using System.Globalization;
Console.WriteLine("SALVE");

Console.WriteLine("Insira o código, a quantidade e o valor da peeça 1:");

string[] vet = Console.ReadLine().Split(' ');
int cod1 = int.Parse(vet[0]);
int pecas1 = int.Parse(vet[1]);
double value1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

Console.WriteLine("Insira o código, a quantidade e o valor da peça 2:");
string[] vet2 = Console.ReadLine().Split(' ');
int cod2 = int.Parse(vet2[0]);
int pecas2 = int.Parse(vet2[1]);
double value2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

double count = pecas1 * value1 + pecas2 * value2;

Console.WriteLine("VALOR A PAGAR: R$ " + count.ToString("F2", CultureInfo.InvariantCulture));




