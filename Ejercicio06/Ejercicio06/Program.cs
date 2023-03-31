namespace Ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int añoInicio;
            int añoFin;


            Console.WriteLine("Ingrese un año de inicio: ");

            añoInicio = int.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese un año de fin: ");

            añoFin = int.Parse(Console.ReadLine());

            Console.WriteLine("==================");


            for (int i = añoInicio; i < añoFin; i++)
            {
                if(i % 4 == 0)
                {
                    if (i % 100 != 0 || i % 400 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                
            }
        }
    }
}