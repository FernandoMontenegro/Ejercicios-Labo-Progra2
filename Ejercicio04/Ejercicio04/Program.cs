namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int contador = 0;
            int numeroPerfecto = 1;
            int sumaNumeros = 0;

            while(contador < 4)
            {

                sumaNumeros = 0;
                
                for (int i = 1; i < numeroPerfecto; i++)
                {
                    if(numeroPerfecto % i  == 0)
                    {
                        sumaNumeros += i;
                    }
                }

                if(sumaNumeros == numeroPerfecto)
                {
                    Console.WriteLine(numeroPerfecto + " es un numero perfecto");
                    contador++;
                }

                numeroPerfecto++;
            }

            Console.ReadLine();
        }
    }
}