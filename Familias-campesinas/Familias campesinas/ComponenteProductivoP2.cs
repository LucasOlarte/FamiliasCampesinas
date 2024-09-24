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
    public partial class ComponenteProductivoP2 : Form
    {
        public ComponenteProductivoP2()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComponenteProductivoP1 componenteProductivoP1 = new ComponenteProductivoP1();
            componenteProductivoP1.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdbSiBPA_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBPAState();
        }

        private void rdbNoBPA_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBPAState();
        }

        private void UpdateBPAState()
        {
            if (rdbSiBPA.Checked)
            {
                txtCultivosBPA.Enabled = true;
            }
            else
            {
                txtCultivosBPA.Enabled = false;
            }
        }

        private void rdbSiControlDePlagas_CheckedChanged(object sender, EventArgs e)
        {
            UpdateManejoYControlState();
        }

        private void rdbNoControlDePlagas_CheckedChanged(object sender, EventArgs e)
        {
            UpdateManejoYControlState();
        }

        private void UpdateManejoYControlState()
        {
            if (rdbSiControlDePlagas.Checked)
            {
                grbMetodoDeControl.Enabled = true;
            }
            else
            {
                grbMetodoDeControl.Enabled = false;
            }
        }

        private void rdbControlConQuimicos_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMetodoDeControlState();
        }

        private void rdbControlOrganico_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMetodoDeControlState();
        }

        private void rdbControlBiologico_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMetodoDeControlState();
        }

        private void rdbControlFisico_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMetodoDeControlState();
        }

        private void rdbOtroMetodoControl_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMetodoDeControlState();
        }

        private void UpdateMetodoDeControlState()
        {
            if (rdbOtroMetodoControl.Checked)
            {
                txtOtroControlDePlagas.Enabled = true;
            }
            else
            {
                txtOtroControlDePlagas.Enabled = false;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (IsAnyRadioButtonChecked(grbBuenasPracticas) &&
                IsAnyRadioButtonChecked(grbControlDePlagas) &&
                IsAnyRadioButtonChecked(grbMetodoDeControl))
            {
                MessageBox.Show("Se ha guardado con éxito.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Faltan campos por llenar");
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
