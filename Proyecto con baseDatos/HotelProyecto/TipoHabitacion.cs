using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProyecto
{
    class TipoHabitacion
    {
        private string habitacion;
        private int costo;


        public string Habitacion { get => habitacion; set => habitacion = value; }
        public int Costo { get => costo; set => costo = value; }


        public TipoHabitacion(string habitacion, int costo)
        {
            Habitacion = habitacion;
            Costo = costo;
        }
    }
}
