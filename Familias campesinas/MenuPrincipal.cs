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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnComponenteSocial_Click(object sender, EventArgs e)
        {
            ComponenteSocialP1 componenteSocialP1 = new ComponenteSocialP1();
            componenteSocialP1.Show();
            this.Hide();
        }

        private void btnInformacionGeneral_Click(object sender, EventArgs e)
        {
            InformacionGeneral informacionGeneral = new InformacionGeneral();
            informacionGeneral.Show();
            this.Hide();
        }

        private void btnComponenteProductivo_Click(object sender, EventArgs e)
        {
            ComponenteProductivoP1 componenteProductivoP1 = new ComponenteProductivoP1();
            componenteProductivoP1.Show();
            this.Hide();
        }
    }
}
