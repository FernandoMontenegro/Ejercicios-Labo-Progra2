namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 02
            int numero;
            double cuadrado;
            double cubo;

            Console.WriteLine("Ingrese un numero: ");

            while(!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                Console.WriteLine("Ingrese un numero: ");
            }
            
            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);


            Console.WriteLine($"El cuadrado de {numero} es: {cuadrado}");
            Console.WriteLine($"El cubo de {numero} es: {cubo}");

            Console.ReadKey();
        }
    }
}