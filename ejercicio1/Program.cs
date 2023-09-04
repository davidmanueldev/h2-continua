using System;

class Program
{
    static bool EsPrimo(int numero)
    {
        // Si el número es menor o igual a 1, no es primo
        if (numero <= 1)
        {
            return false;
        }

        // Si el número es 2, es primo
        if (numero == 2)
        {
            return true;
        }

        // Comenzamos la división desde 2 y continuamos hasta N-1
        for (int divisor = 2; divisor < numero; divisor++)
        {
            // Si el número es divisible por el divisor, no es primo
            if (numero % divisor == 0)
            {
                return false;
            }
        }

        // Si ninguna división fue exacta, el número es primo
        return true;
    }

    static void Main()
    {
        Console.Write("Ingrese un número entero positivo: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (EsPrimo(numero))
            {
                Console.WriteLine($"{numero} es un número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} no es un número primo.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número entero válido.");
        }
    }
}
