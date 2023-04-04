namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 1;

            Console.WriteLine("Ingrese de cuantos niveles quiere la piramide: ");

            int nivel = int.Parse(Console.ReadLine());


            for(int i = 0; i < nivel; i++)
            {
                
                for(int j = 0; j < m; j++)
                {
                    Console.Write('*');
                }
                m += 2;
                
                Console.WriteLine();
            }

        }
    }
}