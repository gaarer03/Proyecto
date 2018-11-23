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
        private byte numeroHuespedes;
        private string tipoHabitacion;
        private string comida;
        private int precio;
        private string bebida;
        private int saldo;
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
        public byte NumeroHuespedes
        {
            get => numeroHuespedes;
            set
            {
                if (value < 0)
                {
                    numeroHuespedes = 0;
                }
                else
                {
                    value = numeroHuespedes;
                }
            }

        }

        public string TipoHabitacion { get => tipoHabitacion; set => tipoHabitacion = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Bebida { get => bebida; set => bebida = value; }
        public string Comida { get => comida; set => comida = value; }
        public int Saldo { get => saldo; set => saldo = value; }

        public void Nombre()//Checar la acción de este método
        {

        }

    }
}
