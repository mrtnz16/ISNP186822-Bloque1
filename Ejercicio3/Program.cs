using System;

namespace Ejercicio3_SumaNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int suma = 0;

            Console.WriteLine("Este programa suma números positivos.");
            Console.WriteLine("Presione 0 para obtener la suma.");

            while (true) // Bucle infinito que se detendrá cuando se ingrese 0
            {
                Console.Write("Ingrese un número positivo: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    suma += numero; // Sumar solo si el número es positivo
                }
                else if (numero == 0)
                {
                    break; // Salir del bucle si se ingresa 0
                }
                else
                {
                    Console.WriteLine("Solo se permiten números positivos. Intente de nuevo.");
                }
            }

            // Mostrar la suma después de que se finaliza el ingreso de números
            Console.WriteLine($"La suma de los números ingresados es: {suma}");
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey(); // Esperar a que el usuario presione una tecla antes de cerrar la consola
        }
    }
}
