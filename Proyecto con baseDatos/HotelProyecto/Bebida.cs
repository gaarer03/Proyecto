using System;

namespace HotelProyecto
{
    class Bebida : Cliente
    {
        private string bebidaNombre;
        private int precio;

        public string BebidaNombre { get => bebidaNombre; set => bebidaNombre = value; }
        public int Precio { get => precio; set => precio = value; }


        public Bebida(string bebidaNombre, int precio)
        {
            BebidaNombre = bebidaNombre;
            Precio = precio;
        }

    }
}
