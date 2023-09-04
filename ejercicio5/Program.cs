using System;

class Program
{
    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
        {
            return false;
        }

        if (numero == 2)
        {
            return true;
        }

        if (numero % 2 == 0)
        {
            return false;
        }

        for (int divisor = 3; divisor * divisor <= numero; divisor += 2)
        {
            if (numero % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Ingrese la cantidad de números primos que desea generar: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            int contador = 0;
            int numero = 2;

            Console.WriteLine($"Los primeros {n} números primos son:");

            while (contador < n)
            {
                if (EsPrimo(numero))
                {
                    Console.Write(numero + " ");
                    contador++;
                }

                numero++;
            }

            Console.WriteLine(); // Salto de línea después de la lista de números primos
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número válido mayor que cero.");
        }
    }
}
