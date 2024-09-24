using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Familias_campesinas
{
    public partial class InicioDeSesion : Form
    {
        public InicioDeSesion()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContraseña.Text) || string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(cmbFuncion.Text))
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtUsuario.Text == "Usuario1" && txtContraseña.Text == "1234")
                {
                    InformacionGeneral informacionGeneral = new InformacionGeneral();
                    informacionGeneral.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}