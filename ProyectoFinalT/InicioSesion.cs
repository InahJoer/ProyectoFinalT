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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu openPage02 = new Menu();
            this.Hide();
            openPage02.ShowDialog();
            this.Close();
        }

        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            archivos arch = new archivos();
            Usuarios usuarios = new Usuarios();
            string usuarioLog1 = txtUsuario.Text;
            string contraseñaLog1 = txtContraseña.Text;
            arch.ValidarUsuario(contraseñaLog1, usuarioLog1);
                lblResultado.Visible = true;
            lblResultado.Text = "IngresoExitoso!!";
            Thread.Sleep(3000);
                Menu2 menu = new Menu2();
                this.Hide();
                menu.ShowDialog();
                this.Close();


        }
    }
}

