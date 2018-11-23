using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace HotelProyecto
{
    public partial class form1 : Form
    {
        SerialPort puertoserial;
        public form1()
        {
            InitializeComponent();
        }

        private void rbtnCheckIn_Click(object sender, EventArgs e)
        {

            FormCheck_In formcheckin = new FormCheck_In();
            formcheckin.Show();

        }


        private void rdbMiHabitacion_CheckedChanged(object sender, EventArgs e)
        {

            ControlDeHabitaciones control = new ControlDeHabitaciones(puertoserial);
            control.Show();


        }



        private void rbtnCheckOut_Click(object sender, EventArgs e)
        {

            Form2 checkout = new Form2();
            checkout.Show();
           


        }
    }
}
