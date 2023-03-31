namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //COMIENZO EJERCICIO 01
            int[] numeros = new int[5];
            int maximo = 0;
            int minimo = 0;
            double promedio;
            int sumaNumeros = 0;
            bool banderaMaximo = false;
            bool banderaMinimo = false;

            Console.WriteLine("Ingrese 5 numeros: ");

            for (int i = 0; i < numeros.Length; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    numeros[i] = numero;

                    if (banderaMaximo == false || numeros[i] > maximo)
                    {
                        maximo = numeros[i];
                        banderaMaximo = true;
                    }

                    if (banderaMinimo == false || numeros[i] < minimo)
                    {
                        minimo = numeros[i];
                        banderaMinimo = true;
                    }

                    sumaNumeros += numeros[i];
                }
                else
                {
                    Console.WriteLine("Ingrese un número válido.");
                    i--; //para restar un intento o sino si ingreso 5 veces mal, me termina el for
                }
            }

            promedio = (double)sumaNumeros / numeros.Length;

            Console.WriteLine($"El valor máximo es: {maximo}");
            Console.WriteLine($"El valor mínimo es: {minimo}");
            Console.WriteLine($"El promedio de los numeros ingresados es {promedio}");

            //FIN EJERCICIO 01
        }
    }
}