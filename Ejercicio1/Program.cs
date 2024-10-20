using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            do
            {
                Console.Write("Ingrese un número para determinar si es positivo o negativo, presione 0 para salir: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine("El número {0} es positivo.", numero);
                }
                else if (numero < 0)
                {
                    Console.WriteLine("El número {0} es negativo.", numero);
                }

            } while (numero != 0);
        }
    }
}
