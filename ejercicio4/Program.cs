using System;

class Program
{
    static bool EsBisiesto(int año)
    {
        // Un año es bisiesto si es divisible por 4, pero no por 100, o si es divisible por 400.
        return (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
    }

    static void CalcularFechaSiguiente(ref int dia, ref int mes, ref int año)
    {
        int[] diasPorMes = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (EsBisiesto(año))
        {
            diasPorMes[2] = 29; // Febrero tiene 29 días en un año bisiesto
        }

        dia++;

        if (dia > diasPorMes[mes])
        {
            dia = 1;
            mes++;

            if (mes > 12)
            {
                mes = 1;
                año++;
            }
        }
    }

    static void Main()
    {
        Console.Write("Ingrese el día (1-31): ");
        if (int.TryParse(Console.ReadLine(), out int dia) && dia >= 1 && dia <= 31)
        {
            Console.Write("Ingrese el mes (1-12): ");
            if (int.TryParse(Console.ReadLine(), out int mes) && mes >= 1 && mes <= 12)
            {
                Console.Write("Ingrese el año (número): ");
                if (int.TryParse(Console.ReadLine(), out int año))
                {
                    CalcularFechaSiguiente(ref dia, ref mes, ref año);
                    Console.WriteLine($"La fecha siguiente es: {dia}/{mes}/{año}");
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un año válido.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un mes válido (1-12).");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un día válido (1-31).");
        }
    }
}
