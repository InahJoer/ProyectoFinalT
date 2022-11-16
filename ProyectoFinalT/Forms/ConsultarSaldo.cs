using ProyectoFinalT.Clases;
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
    public partial class ConsultarSaldo : Form
    {
        public ConsultarSaldo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu2 openPage02 = new Menu2();
            this.Hide();
            openPage02.ShowDialog();
            this.Close();
        }

        private void ConsultarSaldo_Load(object sender, EventArgs e)
        { 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            archivos arch = new archivos();
            arch.CargarDatos("OUTPUTS/users.txt");
            Usuarios usuario = new Usuarios();
            label3.Text = usuario.saldo.ToString("C");
                
            
           
        }
    }
}
