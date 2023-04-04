using Entidades;
using System.Runtime.CompilerServices;

namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            int numero;
            char validacion;
            int suma = 0;
            

            while(continuar == true)
            {
                Console.WriteLine("Ingrese un numero:");

                numero = int.Parse(Console.ReadLine());

                suma += numero;

                Console.WriteLine("¿Continuar? (S/N)");

                validacion = char.Parse(Console.ReadLine());

                if(ValidarRespuesta.ValidaS_N(validacion) == false)
                {
                    continuar = false;
                }
            }

            Console.WriteLine($"La suma de numeros ingresados es {suma}");
        }
    }
}