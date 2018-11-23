using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace HotelProyecto
{
    public partial class FormCheck_In : Form,IPago
    {
        Cliente micliente = new Cliente();
        ArrayList alimento;
        ArrayList bebida;
        ArrayList noches;
        ArrayList huespedes;
        ArrayList tipoHabitacion;

        public FormCheck_In()
        {
            InitializeComponent();
            huespedes = new ArrayList();
            huespedes.Add(new NumPersonas(1));
            huespedes.Add(new NumPersonas(2));
            huespedes.Add(new NumPersonas(3));
            huespedes.Add(new NumPersonas(4));
            huespedes.Add(new NumPersonas(5));
            foreach (NumPersonas huespedes in huespedes)
            {
                cmbNumPersonas.Items.Add(huespedes);//Hace falta un .Nombre
            }
            noches = new ArrayList();
            noches.Add(new Noches(1));
            noches.Add(new Noches(2));
            noches.Add(new Noches(3));
            noches.Add(new Noches(4));
            noches.Add(new Noches(5));
            foreach (Noches noches in noches)
            {
                CmbNoches.Items.Add(noches);//Hace falta un .Nombre
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbTarjetacredito_CheckedChanged(object sender, EventArgs e)
        {
            float TotalPagar = float.Parse(lbTotalPagar.Text);
            FormTarjeta formTarjeta = new FormTarjeta(TotalPagar);
            formTarjeta.Show();
            if (Tarjeta(TotalPagar, formTarjeta.Saldo, formTarjeta.Numerotarjeta, formTarjeta.Fecha, formTarjeta.Cvv))
            {
                MessageBox.Show("Pago exitoso", "Resultado de Pago");
            }
        }

        private void lbTotalPagar_Click(object sender, EventArgs e)
        {

        }


        public bool Tarjeta(float total, float saldo, string NumeroTarjeta, string FechaVencimiento, string Cvv)
        {
            string[] mesaño = FechaVencimiento.Split('/');

            try
            {
                if (total > saldo)
                {
                    throw new ApplicationException("Fondos insuficiente, pobre");


                }

                else if (int.Parse(mesaño[1]) < 18)
                {
                    throw new ApplicationException("Tarjeta Vencida");
                }

                return true;
            }
            catch (ApplicationException error)
            {
                MessageBox.Show(error.Message, "¡¡¡PROBLEMA DETECTADO!!!");
                return false;
            }
        }

        public float Efectivo(float total, float efectivo)
        {
            throw new NotImplementedException();
        }

        private void rbtnSi_CheckedChanged(object sender, EventArgs e)
        {
            float TotalPagar = float.Parse(lbTotalPagar.Text);
            FormTarjeta formTarjeta = new FormTarjeta(TotalPagar);
            formTarjeta.Show();
            if (Tarjeta(TotalPagar, formTarjeta.Saldo, formTarjeta.Numerotarjeta, formTarjeta.Fecha, formTarjeta.Cvv))
            {
                MessageBox.Show("Pago exitoso", "Resultado de Pago");
            }
        }
    }

}
