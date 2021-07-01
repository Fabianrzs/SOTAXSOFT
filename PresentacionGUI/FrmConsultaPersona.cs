using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BLL.PersonaService;

namespace PresentacionGUI
{
    public partial class FrmConsultaPersona : Form
    {
        private string tipoDetalle;
        private PersonaService service;
        
        public FrmConsultaPersona(string tipo)
        {
            InitializeComponent();
            tipoDetalle = tipo;
            service = new PersonaService(ConfigConnection.connectionString);
            LoaderTablet();
        }

        private void LoaderTablet()
        {
            ConsultaResponsePersona response = service.ConsultarPersonas(tipoDetalle);

            if (!response.Error)
            {
                DtgPersonaRegistrada.DataSource = response.Personas;
            }
            else
            {
                MessageBox.Show(response.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DtgDetallesRegistrados_DoubleClick(object sender, EventArgs e)
        {
            if (tipoDetalle.Equals("propietario"))
            {
                Propietario propietario = (Propietario)DtgPersonaRegistrada.CurrentRow.DataBoundItem;
                TxtIdentificacion.Text = propietario.Identificacion;
            }
            else if (tipoDetalle.Equals("conductor"))
            {
                Conductor conductor = (Conductor)DtgPersonaRegistrada.CurrentRow.DataBoundItem;
                TxtIdentificacion.Text = conductor.Identificacion;
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtIdentificacion.Text))
            {
                RegistroResponsePersona response = service.RegistroPersona(TxtIdentificacion.text);

                if (!response.Error)
                {
                    Persona persona = response.Persona;

                    if (persona == null)
                    {
                        MessageBox.Show("No se encontro registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else { MessageBox.Show(response.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }
    }
}
