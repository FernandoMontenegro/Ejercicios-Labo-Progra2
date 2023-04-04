namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 1;

            Console.WriteLine("Ingrese de cuantos niveles quiere la piramide: ");

            int nivel = int.Parse(Console.ReadLine());


            for (int i = 1; i <= nivel; i++)
            {
                for(int j = 1; j <= nivel - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < m; k++)
                {
                    Console.Write('*');
                }
                m += 2;
                Console.WriteLine();
            }
        }
    }
}