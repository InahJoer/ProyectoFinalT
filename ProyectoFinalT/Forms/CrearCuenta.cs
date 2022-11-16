using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalT
{
    public partial class CrearCuenta : Form
    {
        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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
            string usua = txtUsuario.Text;
            string cedu = txtCedula.Text;
            string contra = txtContraseña.Text;
            string contra2 = txtContraseña2.Text; 
            double saldo = double.Parse(txtSaldo.Text);
            double puntos = saldo / 1000;            
            arch.AgregarUsuario(contra,usua,cedu,saldo,puntos);
            DialogResult ingresar = MessageBox.Show("Datos Ingresados Correctamente", "Hola",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);

            if (ingresar == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {

        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
