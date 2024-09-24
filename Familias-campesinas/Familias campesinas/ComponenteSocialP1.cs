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
    public partial class ComponenteSocialP1 : Form
    {
        public ComponenteSocialP1()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreApellidoResponsable.Text) ||
                string.IsNullOrEmpty(numNumeroDocumento.Text) ||
                string.IsNullOrEmpty(numNumeroContacto.Text) ||
                string.IsNullOrEmpty(txtCorreo.Text) ||
                !IsGroupBoxFilled(grbCampesino) ||
                !IsGroupBoxFilled(grbDesplazamientoForzado) ||
                !IsGroupBoxFilled(grbRetornadoAlPredio) ||
                !IsGroupBoxFilled(grbNativoMunicipio) ||
                !IsGroupBoxFilled(grbSubsidioDelEstado) ||
                !IsGroupBoxFilled(grbOrganizaciones))
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ComponenteSocialP2 componenteSocialP2 = new ComponenteSocialP2();
                componenteSocialP2.Show();
                this.Hide();
            }
        }

        private bool IsGroupBoxFilled(GroupBox grbCampesino)
        {
            throw new NotImplementedException();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            InformacionGeneral informacionGeneral = new InformacionGeneral();
            informacionGeneral.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdbSiDesplazamiento_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDesplazamientoState();
        }

        private void rdbNoDesplazamiento_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDesplazamientoState();
        }

        private void UpdateDesplazamientoState()
        {
            if (rdbSiDesplazamiento.Checked)
            {
                numAñosDesplazamiento.Enabled = true;
            }
            else
            {
                numAñosDesplazamiento.Enabled = false;
            }
        }

        private void rdbSiRetornado_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRetornadoState();
        }

        private void rdbNoRetornado_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRetornadoState();
        }
        private void UpdateRetornadoState()
        {
            if (rdbSiRetornado.Checked)
            {
                numTiempoRetornado.Enabled = true;
            }
            else
            {
                numTiempoRetornado.Enabled = false;
            }
        }

        private void rdbSiNativo_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNativoState();
        }

        private void rdbNoNativo_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNativoState();
        }
        private void UpdateNativoState()
        {
            if (rdbNoNativo.Checked)
            {
                txtLugarProveniencia.Enabled = true;
            }
            else
            {
                txtLugarProveniencia.Enabled = false;
            }
        }

        private void rdbSiSubsidio_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSubsidioState();
        }

        private void rdbNoSubsidio_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSubsidioState();
        }
        private void UpdateSubsidioState()
        {
            if (rdbSiSubsidio.Checked)
            {
                txtSubsidio.Enabled = true;
            }
            else
            {
                txtSubsidio.Enabled = false;
            }
        }

        private void rdbJuntaDeAccionComunal_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrganizacionesState();
        }

        private void rdbAsociacionProductores_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrganizacionesState();
        }

        private void rdbCooperativas_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrganizacionesState();
        }

        private void rdbOtroOrganizaciones_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrganizacionesState();
        }

        private void rdbNingunaOrganizacion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrganizacionesState();
        }
        private void UpdateOrganizacionesState()
        {
            if (rdbOtroOrganizaciones.Checked)
            {
                txtOtroOrganizaciones.Enabled = true;
                txtNingunaOrganizacion.Enabled = false;
                txtNingunaOrganizacion.Text = string.Empty;
            }
            else if (rdbNingunaOrganizacion.Checked)
            {
                txtOtroOrganizaciones.Enabled = false;
                txtOtroOrganizaciones.Text = string.Empty;
                txtNingunaOrganizacion.Enabled = true;
            }
            else
            {
                txtOtroOrganizaciones.Enabled = false;
                txtNingunaOrganizacion.Enabled = false;
                txtOtroOrganizaciones.Text = string.Empty;
                txtNingunaOrganizacion.Text = string.Empty;
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
