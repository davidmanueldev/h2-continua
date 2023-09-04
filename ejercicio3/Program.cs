using System;

class Program
{
    static bool EsNumeroPerfecto(int numero)
    {
        if (numero <= 1)
        {
            return false;
        }

        int sumaDivisores = 1; // Inicializamos con 1 porque todo número es divisible por sí mismo

        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0)
            {
                sumaDivisores += i;
                if (i != numero / i)
                {
                    sumaDivisores += numero / i;
                }
            }
        }

        return sumaDivisores == numero;
    }

    static void Main()
    {
        Console.Write("Ingrese un número natural positivo: ");
        if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 1)
        {
            if (EsNumeroPerfecto(numero))
            {
                Console.WriteLine($"{numero} es un número perfecto.");
            }
            else
            {
                Console.WriteLine($"{numero} no es un número perfecto.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número natural positivo válido.");
        }
    }
}
