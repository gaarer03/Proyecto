using System;

namespace HotelProyecto
{
    class Bebida : Cliente
    {
        public Bebida(string bebida, int precio)
        {
            this.Bebida = bebida;
            this.Precio = precio;
        }
    }
}
