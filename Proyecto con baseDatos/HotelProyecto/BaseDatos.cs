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
    public partial class BaseDatos : Form
    {
        public BaseDatos()
        {
            InitializeComponent();
        }

        private void habitaciónBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.habitaciónBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.habitacionesDataSet);

        }

        private void BaseDatos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'habitacionesDataSet.Habitación' Puede moverla o quitarla según sea necesario.
            this.habitaciónTableAdapter.Fill(this.habitacionesDataSet.Habitación);

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.habitaciónTableAdapter.INSERTAR(habitaciónTextBox.Text, tipoTextBox.Text, disponibilidadTextBox.Text);
            this.habitaciónTableAdapter.Fill(this.habitacionesDataSet.Habitación);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.habitaciónTableAdapter.EDITAR(habitaciónTextBox.Text, tipoTextBox.Text, disponibilidadTextBox.Text, habitaciónTextBox.Text);
            this.habitaciónTableAdapter.Fill(this.habitacionesDataSet.Habitación);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.habitaciónTableAdapter.BORRAR(habitaciónTextBox.Text);
            this.habitaciónTableAdapter.Fill(this.habitacionesDataSet.Habitación);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.habitaciónTableAdapter.FillBy(habitacionesDataSet.Habitación,tipoTextBox.Text);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.habitaciónTableAdapter.Fill(this.habitacionesDataSet.Habitación);
        }
    }
}
