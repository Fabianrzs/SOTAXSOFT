using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            BtnTarifa.Location = new Point(10, 117);
            BtnGastos.Location = new Point(10, 171);
            BtnReportes.Location = new Point(10, 225);
            BtnTaxis.Location = new Point(10, 279);
            BtnConductores.Location = new Point(10, 333);
            BtnPropietarios.Location = new Point(10, 387);
        }

        private void PctMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            PctMaximizar.Visible = false;
            PctRestaurar.Visible = true;
        }

        private void PctRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            PctRestaurar.Visible = false;
            PctMaximizar.Visible = true;
        }

        private void PctMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PctSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PctMenu_Click(object sender, EventArgs e)
        {
            if (BnfMenu.Width == 222)
            {
                BnfMenu.Visible = false;
                BnfMenu.Width = 66;
                PnlIzquierdo.Width = 93;
                BnfSeparator.Width = 30;
                TrnIda.Show(BnfMenu);
            }
            else
            {
                BnfMenu.Visible = false;
                BnfMenu.Width = 222;
                PnlIzquierdo.Width = 250;
                BnfSeparator.Width = 181;
                TrnRegreso.Show(BnfMenu);
            }
        }

        private void BtnTarifa_Click(object sender, EventArgs e)
        {
            BtnGastos.Location = new Point(10, 256);
            BtnReportes.Location = new Point(10, 310);
            BtnTaxis.Location = new Point(10, 364);
            BtnConductores.Location = new Point(10, 418);
            BtnPropietarios.Location = new Point(10, 472);
            PnlMenuTarifas.Visible = true;

        }

    }
}

//<div>Iconos diseñados por <a href="https://www.flaticon.es/autores/pixel-perfect" title="Pixel perfect">Pixel perfect</a> from <a href="https://www.flaticon.es/" title="Flaticon">www.flaticon.es</a></div>