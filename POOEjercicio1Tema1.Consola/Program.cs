using POOEjercicio1Tema1.Entidades;

namespace POOEjercicio1Tema1.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello, Pyramid!");
                var p = new PiramideCuadrada(10, 10);
                Console.WriteLine(p.MostrarDatos());
                var p3 = new PiramideCuadrada(-1, 10);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            } 
            Console.ReadKey();
        }
    }
}