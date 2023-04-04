namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numeroMax;
            //int numeroMin = 1;
            int suma1;
            int suma2;
            //int a = 1;

            Console.WriteLine("Ingrese un número:");

            numeroMax = int.Parse(Console.ReadLine());



            for (int i = 1;  i <= numeroMax; i++)
            {
                suma1 = 0;
                suma2 = 0;

                if(i>2)
                {
                    for(int j = 1; j < i; j++)
                    {
                        suma1 += j;
                    }
                     //1+2+3 = suma1 = 6 // k= 5 k<=6 primer vuelta con el numero "4" 0==1
                     //0+5, suma2 = 5, 6-6 por el k++
                     //segunda vuelta 5 == 0

                  
                    for(int k = i+1; k <= suma1; k++)
                    {
                        //Console.WriteLine(suma2 + "=="+ suma1+"-"+k);
                        if (suma2 == suma1 - k)
                        {
                            Console.WriteLine("Centro numérico encontrado: " + i);
                            break;
                        }
                        suma2 += k;
                    }
                }
            }
        }
    }
}