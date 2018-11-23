using System;

namespace HotelProyecto
{
    class Alimento :Cliente
    {
        private string aNombre;
        private int precio;

        public string ANombre { get => aNombre; set => aNombre = value; }
        public int Precio { get => precio; set => precio = value; }

        public Alimento(string nombre, int precio)
        {
            ANombre = nombre;
            Precio = precio;
        }

        



    }
}
