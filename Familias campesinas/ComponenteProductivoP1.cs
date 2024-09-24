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
    public partial class ComponenteProductivoP1 : Form
    {
        public ComponenteProductivoP1()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComponenteSocialP2 componenteSocialP2 = new ComponenteSocialP2();
            componenteSocialP2.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdbPredioPropio_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDatosPredioState();
        }

        private void rdbArrendado_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDatosPredioState();
        }

        private void UpdateDatosPredioState()
        {
            if (rdbArrendado.Checked)
            {
                numPagoMensualPredio.Enabled = true;
                grbTituloDelPredio.Enabled = false;
            }
            else if (rdbPredioPropio.Checked)
            {
                numPagoMensualPredio.Enabled = false;
                grbTituloDelPredio.Enabled = true;
            }
        }

        private void rdbAgricola_CheckedChanged(object sender, EventArgs e)
        {
            UpdateActividadPredioState();
        }

        private void rdbPecuaria_CheckedChanged(object sender, EventArgs e)
        {
            UpdateActividadPredioState();
        }

        private void rdbTurismo_CheckedChanged(object sender, EventArgs e)
        {
            UpdateActividadPredioState();
        }

        private void rdbOtroActividadDelPredio_CheckedChanged(object sender, EventArgs e)
        {
            UpdateActividadPredioState();
        }

        private void UpdateActividadPredioState()
        {
            if (rdbOtroActividadDelPredio.Checked)
            {
                txtOtroActividad.Enabled = true;
            }
            else
            {
                txtOtroActividad.Enabled = false;
            }
        }

        private void rdbSiMaterialC_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMaterialCertificadoState();
        }

        private void rdbNoMaterialC_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMaterialCertificadoState();
        }

        private void UpdateMaterialCertificadoState()
        {
            if (rdbSiMaterialC.Checked)
            {
                txtMaterialCertificado.Enabled = true;
            }
            else
            {
                txtMaterialCertificado.Enabled = false;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numLatitud.Text) || string.IsNullOrEmpty(numLongitud.Text) || string.IsNullOrEmpty(numAlturaMSNM.Text) || string.IsNullOrEmpty(numAreaPredio.Text))
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ComponenteProductivoP2 componenteProductivoP2 = new ComponenteProductivoP2();
                componenteProductivoP2.Show();
                this.Hide();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
