using System;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace HotelProyecto
{
    public partial class ControlDeHabitaciones : Form
    {
        SerialPort puertoserial;
        bool rojo = false;
        bool azul = false;
        bool amarillo = false;

        #region Conexion Serial
        public ControlDeHabitaciones(SerialPort puertoserial)
        {
            InitializeComponent();
            try
            {
                puertoserial = new SerialPort();
                puertoserial.BaudRate = 9600;
                puertoserial.PortName = "COM5";
                puertoserial.Open();
            }
            catch (IOException error)
            {
                MessageBox.Show("Intenta en otro puerto" + error);
            }
            this.puertoserial = puertoserial;
        }
        #endregion

        #region Eventos y protocolos de luces

        private void button3_Click(object sender, EventArgs e)
        {
            puertoserial.Write("e");

        }
        private void button4_Click(object sender, EventArgs e)
        {
            puertoserial.Write("a");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!azul)
            {
                puertoserial.Write("s");
                azul = true;
            }
            else
            {
                puertoserial.Write("w");
                azul = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!rojo)
            {
                puertoserial.Write("d");
                rojo = true;
            }
            else
            {
                puertoserial.Write("c");
                rojo = false;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!amarillo)
            {
                puertoserial.Write("o");
                amarillo = true;
            }
            else
            {
                puertoserial.Write("p");
                amarillo = false;
            }
        }
        #endregion

    }
}
