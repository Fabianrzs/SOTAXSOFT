using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Identificacion { get; set; }
        public double NumeroContacto { get; set; }

    }
}
