using System;

namespace Ejercicios06Punto12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hallar nros primos";
            int nro;
            bool noSalir = true;
            do
            {
                Console.Write("Ingrese un nro entero:");
                if (int.TryParse(Console.ReadLine(), out nro))
                {
                    noSalir = false;
                }
                else
                {
                    Console.WriteLine("Error al ingresar el nro entero");
                }

            } while (noSalir);

            for (int i = 1; i <= nro; i++)
            {
                Console.WriteLine(VerPrimo(i) ? $"{i} es primo" : $"{i} no es primo");
            }
            Console.ReadLine();
        }
        private static bool VerPrimo(int numero)
        {
            for (int divisor = 2; divisor <= numero-1; divisor++)
            {
                if (numero % divisor==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
