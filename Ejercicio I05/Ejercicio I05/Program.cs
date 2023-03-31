using Entidades;

namespace Ejercicio_I05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingrese un numero para ver la tabla de multiplicacion: ");

            numero = int.Parse(Console.ReadLine());

            string tablaMultiplicacion = Calculadora.CalcularTablas(numero);

            Console.WriteLine(tablaMultiplicacion);
        }
    }
}