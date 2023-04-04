using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool esPrimo = true;
            Console.Write("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            // iterar a través de todos los números desde 2 hasta num
            for (int i = 2; i <= numero; i++)
            {
                // comprobar si el número actual es primo o no
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                // si el número es primo, mostrarlo por pantalla
                if (esPrimo)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}