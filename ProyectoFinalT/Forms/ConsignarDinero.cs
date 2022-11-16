using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalT.Forms
{
    public partial class ConsignarDinero : Form
    {
        public ConsignarDinero()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu2 menu = new Menu2();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
