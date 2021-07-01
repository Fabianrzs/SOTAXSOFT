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
using static BLL.TaxiService;

namespace PresentacionGUI
{
    public partial class FrmRegistroTaxi : Form
    {
        private TaxiService service;
        public FrmRegistroTaxi()
        {
            InitializeComponent();
            service = new TaxiService(ConfigConnection.connectionString);
            LoaderTablet();
        }
        private void LoaderTablet()
        {
            ConsultaResponse response = service.Consultar();

            if (!response.Error)
            {
                DtgTaxisRegistrados.DataSource = response.Taxis;
            }
            else { MessageBox.Show(response.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                GuardarTaxi();
            }
        }

        private void GuardarTaxi()
        {
            Taxi taxi = new Taxi()
            {
                Placa = TxtPlaca.Text,
                Modelo = TxtModelo.Text,
                Kilometraje = Convert.ToDouble(TxtKilometraje.Text)
            };

            string mensaje = service.Guardar(taxi, TxtPropietario.Text, TxtConductor.Text);
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (mensaje.Equals("Registro guardado satisfactoriamente")) LimpiarCampos(this); LoaderTablet();

        }

        private void LimpiarCampos(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox)c.Text = "";
                if (c.Controls.Count > 0) LimpiarCampos(c);
            } TxtPlaca.Focus();
        }

    }
}
