namespace Entidades
{
    public class Validar
    {
        public static bool Validacion(int valor, int min, int max)
        {
            if(valor >= min && valor <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}