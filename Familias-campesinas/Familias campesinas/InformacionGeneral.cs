using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Familias_campesinas
{
    public partial class InformacionGeneral : Form
    {
        public InformacionGeneral()
        {
            InitializeComponent();
        }

        private void txtPredioOtro_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVereda.Text) || string.IsNullOrEmpty(txtNombrePredio.Text) || string.IsNullOrEmpty(numDistanciaPredio.Text) || string.IsNullOrEmpty(numTiempoTransporte.Text))
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ComponenteSocialP1 componenteSocialP1 = new ComponenteSocialP1();
                componenteSocialP1.Show();
                this.Hide();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioDeSesion inicioDeSesion = new InicioDeSesion();
            inicioDeSesion.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdbPropio_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextBoxState();
        }

        private void rdbCompraVenta_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextBoxState();
        }

        private void rdbArrendado_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextBoxState();
        }

        private void rdbPredioOtro_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextBoxState();
        }

        private void UpdateTextBoxState()
        {
            if (rdbPredioOtro.Checked)
            {
                txtPredioOtro.Enabled = true;
            }
            else
            {
                txtPredioOtro.Enabled = false;
            }
        }

        private void rdbAPie_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTransporteState();
        }

        private void rdbBestia_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTransporteState();
        }

        private void rdbMoto_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTransporteState();
        }

        private void rdbBicicleta_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTransporteState();
        }

        private void rdbCarro_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTransporteState();
        }

        private void rdbTransporteOtro_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTransporteState();
        }

        private void UpdateTransporteState()
        {
            if (rdbTransporteOtro.Checked)
            {
                txtTransporteOtro.Enabled = true;
            }
            else
            {
                txtTransporteOtro.Enabled = false;
            }
        }

        private void grbPredio_Enter(object sender, EventArgs e)
        {

        }

        private void rdbDestapada_CheckedChanged(object sender, EventArgs e)
        {
            UpdateViaState();
        }

        private void rdbPavimentada_CheckedChanged(object sender, EventArgs e)
        {
            UpdateViaState();
        }

        private void rdbEmpedrada_CheckedChanged(object sender, EventArgs e)
        {
            UpdateViaState();
        }

        private void rdbEnRiel_CheckedChanged(object sender, EventArgs e)
        {
            UpdateViaState();
        }

        private void rdbViaOtro_CheckedChanged(object sender, EventArgs e)
        {
            UpdateViaState();
        }

        private void UpdateViaState()
        {
            if (rdbViaOtro.Checked)
            {
                txtViaOtro.Enabled = true;
            }
            else
            {
                txtViaOtro.Enabled = false;
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
