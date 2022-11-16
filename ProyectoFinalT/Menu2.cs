using ProyectoFinalT.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalT
{
    public partial class Menu2 : Form
    {
        public Menu2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarSaldo openPage02 = new ConsultarSaldo();
            this.Hide();
            openPage02.ShowDialog();
            this.Close();
        }

        private void btnConsularPuntos_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            Console.WriteLine("Sus puntos son: ");
            Console.WriteLine(usuarios.puntos);
            Thread.Sleep(5000);
        }

        private void btnCanjearPuntos_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Amigo, vas a salir, estas seguro de ello?", "componentes",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

            if (salir == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
