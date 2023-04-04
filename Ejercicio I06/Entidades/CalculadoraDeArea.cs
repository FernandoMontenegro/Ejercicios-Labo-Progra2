namespace Entidades
{
    public class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            double areaCuadrado;

            areaCuadrado = longitudLado * longitudLado;

            return areaCuadrado;
        }
        public static double CalcularAreaTriangulo(double baseTriangulo, double altura) 
        {
            double areaTriangulo;

            areaTriangulo = baseTriangulo * altura / 2;

            return areaTriangulo;
        }
        public static double CalcularAreaCirculo(double radio) 
        {
            double areaCirculo;

            areaCirculo = Math.PI * radio * radio;

            return areaCirculo;
        }
    }
}