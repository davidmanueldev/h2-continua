// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Ingrese un número: ");
//         int n = int.Parse(Console.ReadLine());

//         for (int i = 1; i <= n; i++)
//         {
//             for (int j = 1; j <= i; j++)
//             {
//                 Console.Write(i);
//             }
//             Console.WriteLine();
//         }
//     }
// }

using System;

namespace continua {
	class ejercicio9 {

		static void Main(string[] args) {
			double a;
			double b;
			double c;
			double n;
			Console.Write("Escribe un numero: ");
			n = Double.Parse(Console.ReadLine());
			for (a=n; a>=1; --a) {
				for (b=1; b<=a; ++b) {
					Console.Write(" ");
				}
				for (c=a; c<=n; ++c) {
					Console.Write(n-a+1+" ");
				}
				Console.WriteLine("");
			}
		}

	}

}

