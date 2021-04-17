using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Taxi
    {
        public string Placa{ get; set; }
        public double Modelo { get; set; }
        public double Kilometraje { get; set; }
        public Propietario Propietario { get; set; }
        public Condutor Condutor { get; set; }

        public Taxi(Propietario propietario, Condutor condutor)
        {
            Propietario = propietario;
            Condutor = condutor;
        }
    }
}
