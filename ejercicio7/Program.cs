// Hacer un algoritmo que haga el MCD de 2 numeros en C#

int num1, num2;

Console.Write("Ingrese el primer número: ");
num1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número: ");
num2 = int.Parse(Console.ReadLine());

while (num2 != 0)
{
    int temp = num2;
    num2 = num1 % num2;
    num1 = temp;
}

int mcd = num1;
Console.WriteLine("El Máximo Común Divisor es: " + mcd);

// izi pizi tu jefa en bici :v