using Entidades;

namespace Ejercicio16_Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Juan", "Pérez", 1234);
            alumno1.Estudiar(7, 8);
            alumno1.CalcularFinal();

            string mostrarAlumno = alumno1.Mostrar();

            Console.WriteLine("Alumno 1:");
            Console.WriteLine(mostrarAlumno);

            Alumno alumno2 = new Alumno("María", "González", 5678);
            alumno2.Estudiar(6, 2);
            alumno2.CalcularFinal();
            mostrarAlumno = alumno2.Mostrar();

            Console.WriteLine("Alumno 2:");
            Console.WriteLine(mostrarAlumno);

            Alumno alumno3 = new Alumno("Pedro", "Sánchez", 9101);
            alumno3.Estudiar(4, 5);
            alumno3.CalcularFinal();
            mostrarAlumno = alumno3.Mostrar();

            Console.WriteLine("Alumno 3:");
            Console.WriteLine(mostrarAlumno);

        }
    }
}