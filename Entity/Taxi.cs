using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Taxi
    {
        public string Placa { get; set; }
        public double Modelo { get; set; }
        public double Kilometraje { get; set; }
        public Propietario Propietario { get; set; }
        public Conductor Conductor { get; set; }

        public Taxi(Propietario propietario, Conductor conductor)
        {
            Propietario = propietario;
            Conductor = conductor;
        }
        public Taxi(Propietario propietario)
        {
            Propietario = propietario;
        }

        public Taxi()
        {
             
        }

    }
}
