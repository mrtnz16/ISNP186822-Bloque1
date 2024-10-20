using System;

namespace Ejercicio2_TablaMultiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.Write("Ingrese un número entre 1 y 10 para ver su tabla de multiplicar (0 para salir): ");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 1 && numero <= 10)
                {
                    Console.WriteLine($"\nTabla de multiplicar del {numero}:");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{numero} x {i} = {numero * i}");
                    }
                }
                else if (numero != 0)
                {
                    Console.WriteLine("Número fuera del rango. Intente de nuevo.");
                }

                Console.WriteLine(); // Línea en blanco para mejor legibilidad
            } while (numero != 0);
        }
    }
}
