using POOEjercicio1Tema1.Entidades;
using System.Text;

namespace POOEjercicio1Tema1.Testing
{
    [TestClass]
    public class PiramideTesting
    {
        [TestMethod]
        public void CrearPiramideValidaTest()
        {
            int lado = 10;
            int altura = 10;
            PiramideCuadrada pc = new PiramideCuadrada(lado, altura);
            Assert.AreEqual(12.25.ToString(),pc.GetArista().ToString("N"));

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CrearPiramideInvalidaTest()
        {
            int lado = 0;
            int altura = 0;
            var pc=new PiramideCuadrada(lado,altura);
        }
        [TestMethod]
        public void PiramideObtenerVolumenTest()
        {
            int lado = 10;
            int altura = 10;
            PiramideCuadrada pc = new PiramideCuadrada(lado, altura);
            Assert.AreEqual(333.33.ToString(), pc.GetVolumen().ToString("N"));

        }
        [TestMethod]
        public void PiramideObtenerSuperficieTest()
        {
            int lado = 10;
            int altura = 10;
            PiramideCuadrada pc = new PiramideCuadrada(lado, altura);
            Assert.AreEqual(323.61.ToString(), pc.GetArea().ToString("N"));

        }
        [TestMethod]
        public void PiramideMostrarDatosTest()
        {
            int lado = 10;
            int altura = 10;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pirámide Cuadrada");
            sb.AppendLine($"Lado base: 10");
            sb.AppendLine($"Altura...: 10");
            sb.AppendLine($"Arista...: 12,25");
            sb.AppendLine($"Superficie: 323,61");
            sb.AppendLine($"Volumen...: 333,33");
            PiramideCuadrada pc = new PiramideCuadrada(lado, altura);
            Assert.AreEqual(sb.ToString(), pc.MostrarDatos());
        }
    }
}