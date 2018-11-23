using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProyecto
{
    class Cliente
    {
        private byte noches;

        private string tipoHabitacion;

        private float saldo;
        private string nombre;



        public byte Noches
        {
            get => noches;
            set
            {
                if (value < 0)
                {
                    noches = 0;
                }
                else
                {
                    value = noches;
                }
            }
        }
     
        public string TipoHabitacion { get => tipoHabitacion; set => tipoHabitacion = value; }
      public float Saldo { get => saldo; set => saldo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Cliente ()
        {

        }

        public Cliente (string nombre)
        {
            this.Nombre = nombre;
        }
    }
}
