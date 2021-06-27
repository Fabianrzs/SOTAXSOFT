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
    public partial class FrmModificaPersona : Form
    {
        private string tipoDetalle;
        private PersonaService service;

        public FrmModificaPersona(string tipo)
        {
            InitializeComponent();
            tipoDetalle = tipo;
            service = new PersonaService(ConfigConnection.connectionString);
            LoaderTablet();
        }

        private void LoaderTablet()
        {
            ConsultaResponse response = service.Consultar(tipoDetalle);

            if (!response.Error)
            {
                DtgPersonaRegistrada.DataSource = response.Personas;
            }
            else
            {
                MessageBox.Show(response.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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


        private void DtgPersonaRegistrada_DoubleClick(object sender, EventArgs e)
        {
            if (tipoDetalle.Equals("propietario"))
            {
                Propietario propietario = (Propietario)DtgPersonaRegistrada.CurrentRow.DataBoundItem;
                TxtIdentificacion.Text = propietario.Identificacion;
                TxtPrimerNombre.Text = propietario.PrimerNombre;
                TxtSegundoNombre.Text = propietario.SegundoNombre;
                TxtPrimerApellido.Text = propietario.PrimerApellido;
                TxtSegundoApellido.Text = propietario.SegundoApellido;
                TxtNumeroContacto.Text = propietario.NumeroContacto;
            }
            else if (tipoDetalle.Equals("conductor"))
            {
                Conductor conductor = (Conductor)DtgPersonaRegistrada.CurrentRow.DataBoundItem;
                TxtIdentificacion.Text = conductor.Identificacion;
                TxtPrimerNombre.Text = conductor.PrimerNombre;
                TxtSegundoNombre.Text = conductor.SegundoNombre;
                TxtPrimerApellido.Text = conductor.PrimerApellido;
                TxtSegundoApellido.Text = conductor.SegundoApellido;
                TxtNumeroContacto.Text = conductor.NumeroContacto;
            } 
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtIdentificacion.Text))
            {
                RegistroResponse response = service.Registro(TxtIdentificacion.Text);

                if (!response.Error)
                {
                    Persona persona = response.Persona;

                    if(persona != null)
                    {
                        TxtIdentificacion.Text = persona.Identificacion;
                        TxtPrimerNombre.Text = persona.PrimerNombre;
                        TxtSegundoNombre.Text = persona.SegundoNombre;
                        TxtPrimerApellido.Text = persona.PrimerApellido;
                        TxtSegundoApellido.Text = persona.SegundoApellido;
                        TxtNumeroContacto.Text = persona.NumeroContacto;
                    }
                    else{ MessageBox.Show("No se encontro registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    
                }
                else{MessageBox.Show(response.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);}

            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (tipoDetalle.Equals("propietario"))
                    GuardarPropietario();
                else if (tipoDetalle.Equals("conductor"))
                    GuardarConductor();
            }
            else
            {
                MessageBox.Show("Verifique los campos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GuardarPropietario()
        {
            Propietario propietario = new Propietario()
            {
                Identificacion = TxtIdentificacion.Text,
                PrimerNombre = TxtPrimerNombre.Text,
                SegundoNombre = TxtSegundoNombre.Text,
                PrimerApellido = TxtPrimerApellido.Text,
                SegundoApellido = TxtSegundoApellido.Text,
                NumeroContacto = TxtNumeroContacto.Text,
            };

            string mensaje = service.Modificar(propietario, TxtIdentificacion.Text);

            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mensaje.Equals("Registro modificado satisfactoriamente")) LimpiarCampos(this); LoaderTablet();

        }

        private void GuardarConductor()
        {

            Conductor conductor = new Conductor()
            {
                Identificacion = TxtIdentificacion.Text,
                PrimerNombre = TxtPrimerNombre.Text,
                SegundoNombre = TxtSegundoNombre.Text,
                PrimerApellido = TxtPrimerApellido.Text,
                SegundoApellido = TxtSegundoApellido.Text,
                NumeroContacto = TxtNumeroContacto.Text,
            };
            string mensaje = service.Modificar(conductor, TxtIdentificacion.Text);

            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mensaje.Equals("Registro modificado satisfactoriamente")) LimpiarCampos(this); LoaderTablet();

        }

        private void LimpiarCampos(Control parent)
        {

            foreach (Control c in parent.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
                if (c.Controls.Count > 0)
                {
                    LimpiarCampos(c);
                }
            }

            TxtIdentificacion.Focus();
        }


    }
}
