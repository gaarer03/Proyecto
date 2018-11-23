using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace HotelProyecto
{
    public partial class FormMenú : Form
    {
        private float totalPagar;

        Cliente micliente = new Cliente();
        List<Alimento> alimento;
        List<Alimento> bebida;

        public float TotalPagar { get => totalPagar; set => totalPagar = value; }

        // Constructor con TotalPagar
        public FormMenú(float TotalPagar)
        {
            InitializeComponent();
            this.TotalPagar = TotalPagar;
            lbsubTotal.Text = this.TotalPagar.ToString();
            alimento = new List<Alimento>();
            alimento.Add(new Alimento("Pizza", 150));
            alimento.Add(new Alimento("Papas a la francesa", 30));
            alimento.Add(new Alimento("Sandwich de atún", 45));
            alimento.Add(new Alimento("Nachos", 40));
            alimento.Add(new Alimento("Sope", 50));
            foreach (Alimento Comida in alimento)
            {
                cmbAlimentos.Items.Add(Comida.ANombre);//Hace falta un .Nombre para poder leerlo
            }
            bebida = new List<Alimento>();
            bebida.Add(new Alimento("Agua (100ml)", 20));
            bebida.Add(new Alimento("Refresco lata", 20));
            bebida.Add(new Alimento("Limonada", 35));
            bebida.Add(new Alimento("Margarita", 50));
            bebida.Add(new Alimento("Cerveza", 45));
            foreach (Alimento Bebida in bebida)
            {
                cmbBebidas.Items.Add(Bebida.ANombre);//Hace falta un .Nombre para poder leerlo
            }
        }
        private void cmbBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            dvgPedidos.Rows.Add(cmbBebidas.SelectedItem.ToString());
            //dvgPedidos.CurrentRow.Cells[1].Value = 0;


        }

        private void cmbAlimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            dvgPedidos.Rows.Add(cmbAlimentos.SelectedItem.ToString());
            //dvgPedidos.CurrentRow.Cells[1].Value = 0;

        }

        private void dvgPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int cantidad = int.Parse(dvgPedidos.Rows[e.RowIndex].Cells[1].FormattedValue.ToString()); //dvgPedidos.CurrentCell.Value;

            string food = dvgPedidos.Rows[e.RowIndex].Cells[0].Value.ToString();
            bool encontrado = false;
            int i = 0;
            int cost = 0;
            while (encontrado == false)

            {
                if (bebida[i].ANombre == food)
                {
                    cost = bebida[i].Precio;
                    encontrado = true;
                }
                else if (alimento[i].ANombre == food)
                {
                    cost = alimento[i].Precio;
                    encontrado = true;
                }
                i++;
            }
            int total = cost * cantidad;

            dvgPedidos.Rows[e.RowIndex].Cells[2].Value = total;

            dvgPedidos[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Yellow;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            int totalmenu = 0;
            for (int i = 0; i < dvgPedidos.RowCount; i++)
            {
                totalmenu = +int.Parse(dvgPedidos.Rows[i].Cells[2].Value.ToString());
            }
            lbTotalMenu.Text = totalmenu.ToString();
            int total = int.Parse(lbTotalMenu.Text) + int.Parse(lbsubTotal.Text);
            lbTOTAL.Text = total.ToString();

            float TPagar = float.Parse(lbTOTAL.Text);
            FormTarjeta formTarjeta = new FormTarjeta(TPagar);
            formTarjeta.Show();
            this.Close();
        }
    }
}