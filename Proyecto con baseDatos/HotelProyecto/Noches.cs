using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProyecto
{
    class Noches :Cliente
    {
        private byte numero;

        public byte Numero { get => numero; set => numero = value; }

        public Noches (byte numero)
         {
             this.Numero = numero;
         }
    }
}
