using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProyecto
{
    class NumPersonas : Cliente
    {
        private byte numeroHuespedes;


        public byte NumeroHuespedes { get => numeroHuespedes; set => numeroHuespedes = value; }

        public NumPersonas(byte numHuespedes)
        {
            NumeroHuespedes = numeroHuespedes;
        }

        
    }
}
