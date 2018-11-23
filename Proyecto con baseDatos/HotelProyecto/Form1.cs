using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbtnCheckIn_Click(object sender, EventArgs e)
        {
          
            FormCheck_In formcheckin = new FormCheck_In();
            formcheckin.Show();

        }

    }
}
