using Entidades;

namespace Ejercicio17_Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dibujo;

            Boligrafo lapicera = new Boligrafo(20, ConsoleColor.Green);

            Console.WriteLine(lapicera.GetTinta());

            lapicera.Pintar(10, out dibujo);

            Console.WriteLine(dibujo);

            Console.WriteLine(lapicera.GetTinta());

            Console.WriteLine(lapicera.GetColor());

            lapicera.Recargar();

            Console.WriteLine(lapicera.GetTinta());

            lapicera.Pintar(50, out dibujo);

            Console.WriteLine(dibujo);

            Console.WriteLine(lapicera.GetTinta());
        }
    }
}