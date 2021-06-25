using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace PresentacionGUI
{
    public partial class FrmRegistroPersona : Form
    {
        private string tipoDetalle;
        public FrmRegistroPersona(string tipoDetalle)
        {
            InitializeComponent();
            this.tipoDetalle = tipoDetalle;
        }

        private void TxtIdentificacion_Validated(object sender, EventArgs e)
        {
            Error.SetError(TxtIdentificacion, "");
        }

        private void TxtIdentificacion_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarCampoNumerico(TxtIdentificacion.Text, out string mensaje))
            {
                Error.SetError(TxtIdentificacion, mensaje);
                e.Cancel = true;
                TxtIdentificacion.Select(0, TxtIdentificacion.Text.Length);
            }
        }

        private bool ValidarCampoNumerico(string numero, out string mensaje)
        {
            if (numero.Equals(""))
            {
                mensaje = "Campo obligatorio";
                return false;
            }
            else
            {
                bool succes = double.TryParse(numero, out double result);
                if (!succes)
                {
                    mensaje = "No se admiten letras en un campo numerico";
                    return false;
                }
            }
            mensaje = "Campo validado correctamente";
            return true;
        }

        private void TxtPrimerNombre_Validated(object sender, EventArgs e)
        {
            Error.SetError(TxtPrimerNombre, "");
        }

        private void TxtPrimerNombre_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarCampoVacio(TxtPrimerNombre.Text, out string mensaje))
            {
                Error.SetError(TxtPrimerNombre, mensaje);
                e.Cancel = true;
                TxtPrimerNombre.Select(0, TxtPrimerNombre.Text.Length);
            }
        }

        private bool ValidarCampoVacio(string texto, out string mensaje)
        {
            if (texto.Equals(""))
            {
                mensaje = "Campo obligatorio";
                return false;
            }
            mensaje = "Campo validado correctamente";
            return true;
        }

        private void TxtSegundoNombre_Validated(object sender, EventArgs e)
        {
            Error.SetError(TxtSegundoNombre, "");
        }

        private void TxtSegundoNombre_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarCampoVacio(TxtSegundoNombre.Text, out string mensaje))
            {
                Error.SetError(TxtSegundoNombre, mensaje);
                e.Cancel = true;
                TxtSegundoNombre.Select(0, TxtSegundoNombre.Text.Length);
            }
        }

        private void TxtPrimerApellido_Validated(object sender, EventArgs e)
        {
            Error.SetError(TxtPrimerApellido, "");
        }

        private void TxtPrimerApellido_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarCampoVacio(TxtPrimerApellido.Text, out string mensaje))
            {
                Error.SetError(TxtPrimerApellido, mensaje);
                e.Cancel = true;
                TxtPrimerApellido.Select(0, TxtPrimerApellido.Text.Length);
            }
        }

        private void TxtSegundoApellido_Validated(object sender, EventArgs e)
        {
            Error.SetError(TxtSegundoApellido, "");
        }

        private void TxtSegundoApellido_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarCampoVacio(TxtSegundoApellido.Text, out string mensaje))
            {
                Error.SetError(TxtSegundoApellido, mensaje);
                e.Cancel = true;
                TxtSegundoApellido.Select(0, TxtSegundoApellido.Text.Length);
            }
        }

        private void TxtNumeroContacto_Validated(object sender, EventArgs e)
        {
            Error.SetError(TxtNumeroContacto, "");
        }

        private void TxtNumeroContacto_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarCampoNumerico(TxtNumeroContacto.Text, out string mensaje))
            {
                Error.SetError(TxtNumeroContacto, mensaje);
                e.Cancel = true;
                TxtNumeroContacto.Select(0, TxtNumeroContacto.Text.Length);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (tipoDetalle.Equals("propietario"))
                GuardarPropietario();
            else if (tipoDetalle.Equals("conductor"))
                GuardarConductor();
        }

        private void GuardarPropietario()
        {
            PersonaService personaService = new PersonaService(ConfigConnection.connectionString);
            Propietario propietario = new Propietario()
            {
                Identificacion = TxtIdentificacion.Text,
                PrimerNombre = TxtPrimerNombre.Text,
                SegundoNombre = TxtSegundoNombre.Text,
                PrimerApellido = TxtPrimerApellido.Text,
                SegundoApellido = TxtSegundoApellido.Text,
                NumeroContacto = TxtNumeroContacto.Text
            };
            MessageBox.Show(personaService.Guardar(propietario), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GuardarConductor()
        {
            PersonaService personaService = new PersonaService(ConfigConnection.connectionString);
            Conductor conductor = new Conductor()
            {
                Identificacion = TxtIdentificacion.Text,
                PrimerNombre = TxtPrimerNombre.Text,
                SegundoNombre = TxtSegundoNombre.Text,
                PrimerApellido = TxtPrimerApellido.Text,
                SegundoApellido = TxtSegundoApellido.Text,
                NumeroContacto = TxtNumeroContacto.Text
            };
            MessageBox.Show(personaService.Guardar(conductor), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
