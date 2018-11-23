

namespace LibMoneda
{
    public class Moneda
    {
        private string nombre;
        private float valor;

        public Moneda(string nombre, float valor)
        {
            Nombre = nombre;
            Valor = valor;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public float Valor { get => valor; set => valor = value; }
    }
}
