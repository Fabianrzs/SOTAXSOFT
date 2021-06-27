﻿using BLL;
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
    public partial class FrmEliminarPersona : Form
    {
        private string tipoDetalle;
        private PersonaService service;
        public FrmEliminarPersona(string tipo)
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

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtIdentificacion.text))
            {
                RegistroResponse response = service.Registro(TxtIdentificacion.text);

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

        private void DtgPersonaRegistrada_DoubleClick(object sender, EventArgs e)
        {
            if (tipoDetalle.Equals("propietario"))
            {
                Propietario propietario = (Propietario)DtgPersonaRegistrada.CurrentRow.DataBoundItem;
                TxtIdentificacion.text = propietario.Identificacion;
            }
            else if (tipoDetalle.Equals("conductor"))
            {
                Conductor conductor = (Conductor)DtgPersonaRegistrada.CurrentRow.DataBoundItem;
                TxtIdentificacion.text = conductor.Identificacion;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                MessageBox.Show(service.Eliminar(TxtIdentificacion.text), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); LoaderTablet();
            }
        }
    }
}
