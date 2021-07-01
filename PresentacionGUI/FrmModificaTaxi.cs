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
    public partial class FrmModificaTaxi : Form
    {
        private TaxiService service;
        public FrmModificaTaxi()
        {
            InitializeComponent();
            service = new TaxiService(ConfigConnection.connectionString);
            LoaderTablet();
        }

        private void addsColumnas()
        {
            DtgTaxisRegistrados.ColumnCount = 7;
            DtgTaxisRegistrados.ColumnHeadersVisible = true;

            DtgTaxisRegistrados.Columns[0].Name = "Placa";
            DtgTaxisRegistrados.Columns[1].Name = "Modelo";
            DtgTaxisRegistrados.Columns[2].Name = "Kilometraje";
            DtgTaxisRegistrados.Columns[3].Name = "Identificacion Propietario";
            DtgTaxisRegistrados.Columns[4].Name = "Propietario";
            DtgTaxisRegistrados.Columns[5].Name = "Identificacion Conductor";
            DtgTaxisRegistrados.Columns[6].Name = "Conductor";

        }

        private void LoaderTablet()
        {
            ConsultaResponseTaxi response = service.ConsultarTaxis();
            DtgTaxisRegistrados.Rows.Clear();
            if (!response.Error)
            {
                addsColumnas();
                foreach (var item in response.Taxis)
                {
                    DtgTaxisRegistrados.Rows.Add(item.Placa, item.Modelo, item.Kilometraje,
                        item.Propietario.Identificacion,
                        $"{ item.Propietario.PrimerNombre} {item.Propietario.PrimerApellido}",
                        item.Conductor.Identificacion,
                        $"{ item.Conductor.PrimerNombre} {item.Conductor.PrimerApellido}");
                }


            }
            else { MessageBox.Show(response.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtPlaca.Text))
            {
                RegistroResponseTaxi response = service.RegistroTaxi(TxtPlaca.Text);

                if (!response.Error)
                {
                    Taxi taxi = response.Taxi;

                    if (taxi != null)
                    {
                        TxtModelo.Text = taxi.Modelo;
                        TxtKilometraje.Text = taxi.Kilometraje;
                        TxtConductor.Text = taxi.Conductor.Identificacion;
                        TxtPropietario.Text = taxi.Propietario.Identificacion;

                    }
                    else { MessageBox.Show("No se encontro registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                }
                else { MessageBox.Show(response.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                GuardarVehiculo();
            }
            else
            {
                MessageBox.Show("Verifique los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GuardarVehiculo()
        {
            Taxi taxi = new Taxi()
            {
                Modelo = TxtModelo.Text,
                Kilometraje  = TxtKilometraje.Text
            };
            string mensaje = service.ModificarTaxi(taxi, TxtPropietario.Text,TxtConductor.Text,TxtPlaca.Text);

            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mensaje.Equals("Registro modificado satisfactoriamente")) LimpiarCampos(this); LoaderTablet();
        }

        private void LimpiarCampos(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox)c.Text = "";                
                if (c.Controls.Count > 0) LimpiarCampos(c);
                
            }TxtPlaca.Focus();
        }
    }
}
