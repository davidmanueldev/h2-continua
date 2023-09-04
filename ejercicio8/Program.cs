Console.Write("Ingrese el primer número: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número: ");
int n2 = int.Parse(Console.ReadLine());

int mcd = 0;
int a = n1;
int b = n2;

while (b != 0)
{
    int temp = b;
    b = a % b;
    a = temp;
}

mcd = a;
int mcm = (n1 * n2) / mcd;

Console.WriteLine("El Mínimo Común Múltiplo es: " + mcm);