using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace HotelProyecto
{
    public partial class FormMenú : Form
    {
        private float total;

        Cliente micliente = new Cliente();
        ArrayList alimento;
        ArrayList bebida;

        public float Total { get => total; set => total = value; }

        public FormMenú (float Total)
        {
            InitializeComponent();
            this.Total = Total;
            lbsubTotal.Text = this.Total.ToString();
        }

        public FormMenú()
        {

            InitializeComponent();
            alimento = new ArrayList();
            alimento.Add(new Alimentos("Pizza", 150));
            alimento.Add(new Alimentos("Papas a la francesa", 30));
            alimento.Add(new Alimentos("Sandwich de atún", 45));
            alimento.Add(new Alimentos("Nachos", 40));
            alimento.Add(new Alimentos("Sope", 50));
            foreach (Alimentos alimento in alimento)
            {
                cmbAlimentos.Items.Add(alimento);//Hace falta un .Nombre para poder leerlo
            }
            bebida = new ArrayList();
            bebida.Add(new Bebida("Agua (100ml)", 20));
            bebida.Add(new Bebida("Refresco lata", 20));
            bebida.Add(new Bebida("Limonada", 35));
            bebida.Add(new Bebida("Margarita", 50));
            bebida.Add(new Bebida("Cedrveza", 45));
            foreach (Bebida bebida in bebida)
            {
                cmbBebidas.Items.Add(bebida);//Hace falta un .Nombre para poder leerlo
            }


        }
    }
}
