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
    public partial class ComponenteSocialP2 : Form
    {
        public ComponenteSocialP2()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComponenteSocialP1 componenteSocialP1 = new ComponenteSocialP1();
            componenteSocialP1.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdbJuntaDeAccionComunal_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTiempoOrgState();
        }

        private void rdbCooperativas_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTiempoOrgState();
        }

        private void rdbAsociacionProductores_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTiempoOrgState();
        }

        private void rdbOtroTiempoOrganizaciones_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTiempoOrgState();
        }

        private void UpdateTiempoOrgState()
        {
            numTiempoJAC.Enabled = false;
            numTiempoCooperativas.Enabled = false;
            numTiempoAsociaProd.Enabled = false;
            numTiempoOtraOrganizacion.Enabled = false;

            if (rdbJuntaDeAccionComunal.Checked)
            {
                numTiempoJAC.Enabled = true;
            }
            else if (rdbCooperativas.Checked)
            {
                numTiempoCooperativas.Enabled = true;
            }
            else if (rdbAsociacionProductores.Checked)
            {
                numTiempoAsociaProd.Enabled = true;
            }
            else if (rdbOtroTiempoOrganizaciones.Checked)
            {
                numTiempoOtraOrganizacion.Enabled = true;
            }
        }

        private bool IsAnyRadioButtonChecked(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (!IsAnyRadioButtonChecked(grbNucleoCampesino) || !IsAnyRadioButtonChecked(grbNacidosEnVereda))
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ComponenteProductivoP1 componenteProductivoP1 = new ComponenteProductivoP1();
                componenteProductivoP1.Show();
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
