namespace Entidades
{
    public class Fecha
    {
        public static int CalcularDiasVividos(string fechaNacimientoStr)
        {
            DateTime fechaNacimiento = DateTime.ParseExact(fechaNacimientoStr, "dd/MM/yyyy", null);

            TimeSpan diasVividos = DateTime.Now - fechaNacimiento;

            int diasVividosEntero = (int)diasVividos.TotalDays;

            return diasVividosEntero;
        }
    }
}