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
    }
}
