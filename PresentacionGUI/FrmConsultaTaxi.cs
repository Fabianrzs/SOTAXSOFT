
using BLL;
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
    public partial class FrmConsultaTaxi : Form
    {
        private TaxiService service;
        public FrmConsultaTaxi()
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

    }
}
