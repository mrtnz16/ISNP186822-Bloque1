using System;

namespace Ejercicio5_PromedioNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) // Bucle infinito para permitir múltiples cálculos
            {
                double suma = 0; // Variable para acumular la suma
                int contador = 0; // Variable para contar los números ingresados

                Console.WriteLine("Este programa calcula el promedio de los números ingresados.");
                Console.WriteLine("Ingrese los números y presione 0 para calcular el promedio:");

                while (true) // Bucle para ingresar números
                {
                    Console.Write("Ingrese un número: ");
                    string entrada = Console.ReadLine(); // Leer entrada del usuario

                    // Verificar si la entrada es una letra
                    if (!double.TryParse(entrada, out double numero))
                    {
                        return; // Terminar el programa si se ingresa una letra
                    }

                    if (numero == 0) // Si se ingresa 0, calcular el promedio
                    {
                        break; // Salir del bucle para calcular el promedio
                    }

                    suma += numero; // Sumar el número ingresado
                    contador++; // Incrementar el contador
                }

                // Calcular y mostrar el promedio si se ingresaron números
                if (contador > 0)
                {
                    double promedio = suma / contador;
                    Console.WriteLine($"El promedio de los números ingresados es: {promedio}");
                }
                else
                {
                    Console.WriteLine("No se ingresaron números para calcular el promedio.");
                }

                Console.WriteLine("Presione 'Enter' para calcular otro promedio o ingrese una letra para salir.");
                string continuar = Console.ReadLine(); // Leer la entrada del usuario

                // Verificar si se ingresó una letra
                if (!string.IsNullOrWhiteSpace(continuar) && !double.TryParse(continuar, out _))
                {
                    break; // Salir del programa si se ingresa una letra
                }
            }

            Console.WriteLine("Programa finalizado. Presione cualquier tecla para salir.");
            Console.ReadKey(); // Esperar a que el usuario presione una tecla antes de cerrar la consola
        }
    }
}
