using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Data;
using System.Collections.Generic;

namespace HotelProyecto
{
    public partial class FormCheck_In : Form
    {
        Cliente micliente = new Cliente();

        List<TipoHabitacion> tipo;


        public FormCheck_In()
        {
            InitializeComponent();
            tipo = new List<TipoHabitacion>();

            tipo.Add(new TipoHabitacion("Sencilla", 1500));
            tipo.Add(new TipoHabitacion("Doble", 2500));
            tipo.Add(new TipoHabitacion("Penhouse", 10000));
            

            for (int i=1; i<6; i++)
            {
                cmbNumPersonas.Items.Add(i.ToString());
                CmbNoches.Items.Add(i.ToString());
                
            }
            foreach(TipoHabitacion Tipo in tipo)
            {
                cmbTipo.Items.Add(Tipo.Habitacion);

            }
        }

        private void rbtnSi_Click(object sender, EventArgs e)
        {
            float TotalPagar = float.Parse(lbTotalPagar.Text);
            FormMenú formMenú = new FormMenú(TotalPagar);
            formMenú.Show();
            this.Close();
           
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            BaseDatos baseDatos = new BaseDatos();
            baseDatos.Show();
            
        }

        private void rbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            FormTarjeta formTarjeta = new FormTarjeta(float.Parse(lbTotalPagar.Text));
            formTarjeta.Show();
            this.Close();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int noches = int.Parse(CmbNoches.SelectedItem.ToString());
            string nombre = cmbTipo.SelectedItem.ToString();
            bool bandera = false;
            int cost = 0;
            int i = 0;
            while (bandera==false)
            {
                if(tipo[i].Habitacion==nombre)
                {
                    cost = tipo[i].Costo;
                    bandera = true;
                   
                }
                i++;
            }
            int total = cost * noches;
            lbTotalPagar.Text = total.ToString();
        }
    }

}
