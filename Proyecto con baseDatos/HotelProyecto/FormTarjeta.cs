using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LibMoneda;


namespace HotelProyecto
{
    public partial class FormTarjeta : Form
    {
        List<Moneda> monedas;

        private string numerotarjeta;
        private string cvv;
        private string fecha;
        private float totalPagar;
        private float saldo;



        public string Numerotarjeta { get => numerotarjeta; set => numerotarjeta = value; }
        public string Cvv { get => cvv; set => cvv = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public float TotalPagar { get => totalPagar; set => totalPagar = value; }
        public float Saldo { get => saldo; set => saldo = value; }

        public FormTarjeta(float TotalPagar)
        {
            InitializeComponent();

            this.TotalPagar = TotalPagar;
            lbTotalPagar.Text = this.TotalPagar.ToString();


            monedas = new List<Moneda>();
            monedas.Add(new Moneda("Dolar", 20.14f));
            monedas.Add(new Moneda("Euro", 22.83f));
            monedas.Add(new Moneda("Yen", 0.18f));
            foreach (Moneda moneda in monedas)
            {
                cmbMoneda.Items.Add(moneda.Nombre);
            }
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

        private void btnPagarMoneda_Click(object sender, EventArgs e)
        {
            string nombMoneda = cmbMoneda.Text.ToString();
            int i = 0;
            float valor = 0;
            bool bandera = false;
            while (bandera == false)
            {
                if (monedas[i].Nombre == nombMoneda)
                {
                    valor = monedas[i].Valor;
                    bandera = true;
                }
                i++;
            }
            float monedacambio = valor * int.Parse(txtbCantidadMon.Text);
            lbCambiodeMoneda.Text = monedacambio.ToString();

            float cambio = monedacambio - int.Parse(lbTotalPagar.Text);
            lbCambio.Text = cambio.ToString();
        }

        private void btnPago_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("... \n\n Transacción finalizada \n\n ¡Gracias!");
            this.Close();

        }
    }
}
