using Entidades;
using System;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int min = int.MaxValue;
            int max = int.MinValue;
            int suma = 0;

            Console.WriteLine("Ingrese 10 numeros: ");

            for(int i = 0; i < 10; i++)
            {

                numero = int.Parse(Console.ReadLine());

                if(Validar.Validacion(numero, -100, 100) == true)
                {
                    suma += numero;

                    if (numero < min)
                    {
                        min = numero;
                    }

                    if (numero > max)
                    {
                        max = numero;
                    }
                }
                else
                {
                    Console.WriteLine("[ERROR] Rango invalido, reingrese un numero: ");
                    i--;
                }
            }

            double promedio = (double)suma / 10;

            Console.WriteLine($"El valor mínimo es: {min}");
            Console.WriteLine($"El valor máximo es: {max}");
            Console.WriteLine($"El promedio es: {promedio}");

        }
    }
}