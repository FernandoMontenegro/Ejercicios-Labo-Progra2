using Entidades;

namespace Ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? fechaNacimientoStr;
            
            Console.WriteLine("Ingresa tu fecha de nacimiento (dd/mm/yyyy):");
            fechaNacimientoStr = Console.ReadLine();               
            
            int diasVividosEntero = Fecha.CalcularDiasVividos(fechaNacimientoStr);

            Console.WriteLine("Viviste {0} días.", diasVividosEntero);
        }
    }
}