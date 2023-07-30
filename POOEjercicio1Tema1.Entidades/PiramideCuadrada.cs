using System.Text;

namespace POOEjercicio1Tema1.Entidades
{
    public class PiramideCuadrada
    {
        private int _ladoBase;
        private int _altura;
        private double _arista;

        public PiramideCuadrada(int lado, int altura)
        {
            if ((lado <= 0) || (altura <= 0))
            {
                throw new ArgumentException("Valores no válidos");
            }
            _ladoBase = lado;
            _altura = altura;
            _arista = SetArista();
        }
        public int GetAltura() => _altura;
        public int GetLado() => _ladoBase;
        public double GetArista() => _arista;
        private double SetArista()
        {
            return Math.Sqrt(Math.Pow(GetAltura(), 2) + Math.Pow(GetLado(), 2) / 2);
        }
        public double GetArea()
        {
            return GetLado() * (GetLado() + Math.Sqrt(4 * Math.Pow(GetAltura(), 2) + Math.Pow(GetLado(), 2)));
        }
        public double GetVolumen()
        {
            return Math.Pow(GetLado(),2)*GetAltura() / 3;
        }
        public string MostrarDatos()
        {
            StringBuilder sb= new StringBuilder();
            sb.AppendLine($"Pirámide Cuadrada");
            sb.AppendLine($"Lado base.: {GetLado()}");
            sb.AppendLine($"Altura....: {GetAltura()}");
            sb.AppendLine($"Arista....: {GetArista():N}");
            sb.AppendLine($"Superficie: {GetArea():N}");
            sb.AppendLine($"Volumen...: {GetVolumen():N}");
            return sb.ToString();
        }
    }
}