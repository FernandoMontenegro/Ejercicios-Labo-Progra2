using System.Text;

namespace Entidades
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal = -1;
        public string nombre;
        public string apellido;
        public int legajo;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void CalcularFinal()
        {
            if(this.nota1 >= 4 && this.nota2 >= 4)
            {
                Random random = new Random();   
                this.notaFinal = random.Next(4, 11);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Apellido: " + this.apellido);
            sb.AppendLine("Legajo: " + this.legajo);
            sb.AppendLine("Nota 1: " + this.nota1);
            sb.AppendLine("Nota 2: " + this.nota2);
            
            if(this.notaFinal != -1)
            {
                sb.AppendLine("Nota final: " + this.notaFinal);
            }
            else
            {
                sb.AppendLine("Nota final: desaprobado!");
            }

            return sb.ToString();
        }
    }
}