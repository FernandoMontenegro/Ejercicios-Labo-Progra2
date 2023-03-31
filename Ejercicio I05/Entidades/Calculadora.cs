using System.Text;

namespace Entidades
{
    public class Calculadora
    {
        public static string CalcularTablas(int numero)
        {
            int resultado;

            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < 10; i++)
            {
                resultado = numero * i;

                sb.AppendLine($"{numero} x {i} = {resultado}");

            }
            return sb.ToString();
        }
    }
}