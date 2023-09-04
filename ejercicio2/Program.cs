using System;

class Program
{
    static int ContarDigitos(int numero)
    {
        int contador = 1; // Aca hay que comenzar con al menos un dígito

        while (numero >= 10)
        {
            numero = numero / 10;
            contador++;
        }

        return contador;
    }

    static void Main()
    {
        Console.Write("Ingrese un número entero positivo: ");
        if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
        {
            int cantidadDeDigitos = ContarDigitos(numero);
            Console.WriteLine($"El número {numero} necesita {cantidadDeDigitos} dígito(s) para ser representado.");
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número entero positivo válido.");
        }
    }
}
