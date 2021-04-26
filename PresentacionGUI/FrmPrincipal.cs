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
            InicializarMenuPrincipal();
        }
        
        private void AbrirFromHijo(object frmHijo)
        {
            if (this.PnlCentral.Controls.Count > 0)
                this.PnlCentral.Controls.RemoveAt(0);

            Form pnlHijo = frmHijo as Form;
            pnlHijo.TopLevel = false;
            pnlHijo.Dock = DockStyle.Fill;
            this.PnlCentral.Controls.Add(pnlHijo);
            this.PnlCentral.Tag = pnlHijo;
            pnlHijo.Show();
        }

        private void InicializarMenuPrincipal()
        {
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
                BnfMenu.Width = 56;
                PnlIzquierdo.Width = 83;
                BnfSeparator.Width = 20;
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
            if (BnfMenu.Width == 222)
            {
                BtnTarifa.Location = new Point(10, 117);
                BtnGastos.Location = new Point(10, 286);
                BtnReportes.Location = new Point(10, 340);
                BtnTaxis.Location = new Point(10, 394);
                BtnConductores.Location = new Point(10, 448);
                BtnPropietarios.Location = new Point(10, 502);

                PnlMenuTarifas.Visible = true;
                PnlMenuTarifas.Location = new Point(44, 163);
                PnlMenuGatos.Visible = false;
                PnlMenuPropietarios.Visible = false;
                PnlMenuTaxis.Visible = false;
            }
        }

        private void BtnRegistrarTarifa_Click(object sender, EventArgs e)
        {
            PnlMenuTarifas.Visible = false;
            InicializarMenuPrincipal();
            AbrirFromHijo(new FrmRegistraDetalle());
        }

        private void BtnConsultarTarifa_Click(object sender, EventArgs e)
        {
            PnlMenuTarifas.Visible = false;
            InicializarMenuPrincipal();
            AbrirFromHijo(new FrmConsultaDetalle());
        }

        private void BtnModificarTarifa_Click(object sender, EventArgs e)
        {
            PnlMenuTarifas.Visible = false;
            InicializarMenuPrincipal();
            AbrirFromHijo(new FrmModificaDetalle());
        }

        private void BtnGastos_Click(object sender, EventArgs e)
        {
            if (BnfMenu.Width == 222)
            {
                BtnTarifa.Location = new Point(10, 117);
                BtnGastos.Location = new Point(10, 171);
                BtnReportes.Location = new Point(10, 340);
                BtnTaxis.Location = new Point(10, 394);
                BtnConductores.Location = new Point(10, 448);
                BtnPropietarios.Location = new Point(10, 502);

                PnlMenuGatos.Visible = true;
                PnlMenuGatos.Location = new Point(44, 208);
                PnlMenuTarifas.Visible = false;
                PnlMenuPropietarios.Visible = false;
                PnlMenuTaxis.Visible = false;
                PnlMenuConductores.Visible = false;
            }
        }

        private void BtnRegistrarGastos_Click(object sender, EventArgs e)
        {
            PnlMenuGatos.Visible = false;
            InicializarMenuPrincipal();
            AbrirFromHijo(new FrmRegistraDetalle());
        }

        private void BtnConsultarGastos_Click(object sender, EventArgs e)
        {
            PnlMenuGatos.Visible = false;
            InicializarMenuPrincipal();
            AbrirFromHijo(new FrmConsultaDetalle());
        }

        private void BtnModificarGastos_Click(object sender, EventArgs e)
        {
            PnlMenuGatos.Visible = false;
            InicializarMenuPrincipal();
            AbrirFromHijo(new FrmModificaDetalle());
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            if (BnfMenu.Width == 222)
            {
                InicializarMenuPrincipal();
                PnlMenuTaxis.Visible = false;
                PnlMenuPropietarios.Visible = false;
                PnlMenuGatos.Visible = false;
                PnlMenuTarifas.Visible = false;
                PnlMenuConductores.Visible = false;
            }
            AbrirFromHijo(new FrmReportes());

        }

        private void BtnTaxis_Click(object sender, EventArgs e)
        {
            if (BnfMenu.Width == 222)
            {
                BtnTarifa.Location = new Point(10, 117);
                BtnGastos.Location = new Point(10, 171);
                BtnReportes.Location = new Point(10, 225);
                BtnTaxis.Location = new Point(10, 279);
                BtnConductores.Location = new Point(10, 480);
                BtnPropietarios.Location = new Point(10, 534);

                PnlMenuTaxis.Visible = true;
                PnlMenuTaxis.Location = new Point(44, 315);
                PnlMenuPropietarios.Visible = false;
                PnlMenuGatos.Visible = false;
                PnlMenuTarifas.Visible = false;
                PnlMenuConductores.Visible = false;
            }
        }

        private void BtnRegistrarTaxi_Click(object sender, EventArgs e)
        {
            PnlMenuTaxis.Visible = false;
            InicializarMenuPrincipal();
            AbrirFromHijo(new FrmRegistroTaxi());

        }

        private void BtnConsultarTaxi_Click(object sender, EventArgs e)
        {
            PnlMenuTaxis.Visible = false;
            InicializarMenuPrincipal();
            AbrirFromHijo(new FrmConsultaTaxi());
        }

        private void BtnModificarTaxi_Click(object sender, EventArgs e)
        {
            PnlMenuTaxis.Visible = false;
            InicializarMenuPrincipal();
            AbrirFromHijo(new FrmModificaTaxi());
        }

        private void BtnEliminarTaxi_Click(object sender, EventArgs e)
        {
            PnlMenuTaxis.Visible = false;
            InicializarMenuPrincipal();
            AbrirFromHijo(new FrmEliminaTaxi());
        }

        private void BtnConductores_Click(object sender, EventArgs e)
        {
            if (BnfMenu.Width == 222)
            {
                BtnTarifa.Location = new Point(10, 117);
                BtnGastos.Location = new Point(10, 171);
                BtnReportes.Location = new Point(10, 225);
                BtnTaxis.Location = new Point(10, 279);
                BtnConductores.Location = new Point(10, 333);
                BtnPropietarios.Location = new Point(10, 534);

                PnlMenuConductores.Visible = true;
                PnlMenuConductores.Location = new Point(44, 375);
                PnlMenuTaxis.Visible = false;
                PnlMenuPropietarios.Visible = false;
                PnlMenuGatos.Visible = false;
                PnlMenuTarifas.Visible = false;
            }
        }

        private void BtnRegistrarCondutor_Click(object sender, EventArgs e)
        {
            PnlMenuConductores.Visible = false;
            InicializarMenuPrincipal();
            AbrirFromHijo(new FrmRegistroPersona());
        }

        private void BtnConsultarCondutor_Click(object sender, EventArgs e)
        {
            PnlMenuConductores.Visible = false;
            InicializarMenuPrincipal();
            AbrirFromHijo(new FrmConsultaPersona());
        }

        private void BtnModificarCondutor_Click(object sender, EventArgs e)
        {
            PnlMenuConductores.Visible = false;
            InicializarMenuPrincipal();
            AbrirFromHijo(new FrmModificaPersona());
        }

        private void BtnEliminarCondutor_Click(object sender, EventArgs e)
        {
            PnlMenuConductores.Visible = false;
            InicializarMenuPrincipal();
            AbrirFromHijo(new FrmEliminarPersona());
        }

        private void BtnPropietarios_Click(object sender, EventArgs e)
        {
            if (BnfMenu.Width == 222)
            {
                InicializarMenuPrincipal();
                PnlMenuPropietarios.Visible = true;
                PnlMenuPropietarios.Location = new Point(44, 430);
                PnlMenuGatos.Visible = false;
                PnlMenuTarifas.Visible = false;
                PnlMenuTaxis.Visible = false;
                PnlMenuConductores.Visible = false;
            }
        }

        private void BtnRegistrarPropietario_Click(object sender, EventArgs e)
        {
            PnlMenuPropietarios.Visible = false;
            InicializarMenuPrincipal();
            AbrirFromHijo(new FrmRegistroPersona());
        }

        private void BtnConsultarPropietario_Click(object sender, EventArgs e)
        {
            PnlMenuPropietarios.Visible = false;
            InicializarMenuPrincipal();
            AbrirFromHijo(new FrmConsultaPersona());
        }

        private void BtnModificarPropietario_Click(object sender, EventArgs e)
        {
            PnlMenuPropietarios.Visible = false;
            InicializarMenuPrincipal();
            AbrirFromHijo(new FrmModificaPersona());
        }

        private void BtnEliminarPropietario_Click(object sender, EventArgs e)
        {
            PnlMenuPropietarios.Visible = false;
            InicializarMenuPrincipal();
            AbrirFromHijo(new FrmEliminarPersona());
        }
    }
}

//<div>Iconos diseñados por <a href="https://www.flaticon.es/autores/pixel-perfect" title="Pixel perfect">Pixel perfect</a> from <a href="https://www.flaticon.es/" title="Flaticon">www.flaticon.es</a></div>
//<div>Iconos diseñados por <a href="https://www.flaticon.es/autores/kiranshastry" title="Kiranshastry">Kiranshastry</a> from <a href="https://www.flaticon.es/" title="Flaticon">www.flaticon.es</a></div>
//<div>Iconos diseñados por <a href="https://www.freepik.com" title="Freepik">Freepik</a> from <a href="https://www.flaticon.es/" title="Flaticon">www.flaticon.es</a></div>