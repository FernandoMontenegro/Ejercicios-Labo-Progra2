namespace Entidades
{
    public class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            if(c == 'S' || c == 's')
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