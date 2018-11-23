using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Data;
using System.Collections.Generic;

namespace HotelProyecto
{
    public partial class FormCheck_In : Form,IPago
    {
        Cliente micliente = new Cliente();
        ////List<NumPersonas> huespedes = new List<NumPersonas>();
        ArrayList alimento;
        ArrayList bebida;
        ////ArrayList noches;
        ArrayList tipoHabitacion;

        public FormCheck_In()
        {
            InitializeComponent();
            /*huespedes.Add(new NumPersonas(1));
            huespedes.Add(new NumPersonas(2));
            huespedes.Add(new NumPersonas(3));
            huespedes.Add(new NumPersonas(4));
            huespedes.Add(new NumPersonas(5));
            for (int i=0; i < huespedes.Count; i++)
            {
                cmbNumPersonas.Items.Add(huespedes[i].NumeroHuespedes.ToString());
            }
           /////////foreach (NumPersonas huespedes in huespedes)
            {
                cmbNumPersonas.Items.Add(huespedes.NumeroHuespedes);
            }/////////
            noches = new ArrayList();
            noches.Add(new Noches(1));
            noches.Add(new Noches(2));
            noches.Add(new Noches(3));
            noches.Add(new Noches(4));
            noches.Add(new Noches(5));
            foreach (Noches noche in noches)
            {
                CmbNoches.Items.Add(noche.Noches.ToString());//Hace falta un .Nombre
            }*/
            for(int i=1; i<6; i++)
            {
                cmbNumPersonas.Items.Add(i.ToString());
                CmbNoches.Items.Add(i.ToString());
            }
            
        }

        private void rbtnSi_Click(object sender, EventArgs e)
        {
            float TotalPagar = float.Parse(lbTotalPagar.Text);
            FormMenú formMenú = new FormMenú(TotalPagar);
            formMenú.Show();
           
        }

        private void rdbTarjetacredito_CheckedChanged(object sender, EventArgs e)
        {
            int TotalPagar = int.Parse(lbTotalPagar.Text);
            FormTarjeta formTarjeta = new FormTarjeta(TotalPagar);
            formTarjeta.Show();
            if (Tarjeta(TotalPagar, formTarjeta.Saldo, formTarjeta.Numerotarjeta, formTarjeta.Fecha, formTarjeta.Cvv))
            {
                MessageBox.Show("Pago exitoso", "Resultado de Pago");
            }
        }



        public bool Tarjeta(float total, int saldo, string NumeroTarjeta, string FechaVencimiento, string Cvv)
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

        private void button1_Click(object sender, EventArgs e)
        {
            BaseDatos baseDatos = new BaseDatos();
            baseDatos.Show();
        }
    }

}
