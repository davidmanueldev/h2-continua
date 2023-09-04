using System;

namespace Polinomio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de la variable: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el grado del polinomio: ");
            int grado = Convert.ToInt32(Console.ReadLine());

            double[] coeficientes = new double[grado + 1];
            for (int i = 0; i <= grado; i++)
            {
                Console.Write("Ingrese el coeficiente del término de grado " + i + ": ");
                coeficientes[i] = Convert.ToDouble(Console.ReadLine());
            }

            double resultado = 0;
            for (int i = 0; i <= grado; i++)
            {
                resultado += coeficientes[i] * Math.Pow(x, i);
            }

            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}

// Un ejemplo de su funcionamiento seria: 
// Ingrese el valor de la variable: 2
// Ingrese el grado del polinomio: 3
// Ingrese el coeficiente del término de grado 0: 1
// Ingrese el coeficiente del término de grado 1: 2
// Ingrese el coeficiente del término de grado 2: 3
// Ingrese el coeficiente del término de grado 3: 4
// El resultado es: 49

// el polinomio es 1 + 2x + 3x^2 + 4x^3 = 1 + 2*2 + 3*2^2 + 4*2^3 = 49