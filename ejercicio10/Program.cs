using System;

class Program
{
    static bool EsTriangular(int num)
    {
        if (num < 0)
        {
            return false;
        }

        int suma = 0;
        int n = 1;

        while (suma <= num)
        {
            suma += n;
            if (suma == num)
            {
                return true;
            }
            n++;
        }

        return false;
    }

    static void Main()
    {
        while (true)
        {
            Console.Write("Introduce la altura del triángulo (entero positivo): ");
            int n = int.Parse(Console.ReadLine());

            if (!EsTriangular(n))
            {
                Console.WriteLine($"El número {n} no es triangular.");
                continue;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n - i - 1));
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            break;
        }
    }
}
