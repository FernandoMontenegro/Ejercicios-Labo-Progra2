using Entidades;

namespace Ejercicio_I06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double areaCuadrado;
            double areaTriangulo;
            double areaCirculo;

            areaCuadrado = CalculadoraDeArea.CalcularAreaCuadrado(5);
            areaTriangulo = CalculadoraDeArea.CalcularAreaTriangulo(5, 8);
            areaCirculo = CalculadoraDeArea.CalcularAreaCirculo(5);

            Console.WriteLine($"El area del cuadrado es {areaCuadrado}");
            Console.WriteLine($"El area del triangulo es {areaTriangulo}");
            Console.WriteLine($"El area del circulo es {areaCirculo}");
        }
    }
}