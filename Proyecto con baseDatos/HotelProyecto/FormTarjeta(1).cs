using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace HotelProyecto
{
    public partial class FormTarjeta : Form
    {
        private string numerotarjeta;
        private string cvv;
        private string fecha;
        private float totalPagar;
        private float saldo;
        private string nombre;
        


        public string Numerotarjeta { get => numerotarjeta; set => numerotarjeta = value; }
        public string Cvv { get => cvv; set => cvv = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public float TotalPagar { get => totalPagar; set => totalPagar = value; }
        public float Saldo { get => saldo; set => saldo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public FormTarjeta(float TotalPagar)
        {
            InitializeComponent();
            this.TotalPagar = TotalPagar;
            lblTotalPagar.Text = this.TotalPagar.ToString();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            Random saldoVariable = new Random();
            Numerotarjeta = mtbNumeroTarjeta.Text;
            Cvv = mtbCvv.Text;
            Fecha = mtbVencimiento.Text;
            Saldo = (float)saldoVariable.NextDouble() * 1000;
            lbprueba.Text = Fecha;
        }
    }
}
