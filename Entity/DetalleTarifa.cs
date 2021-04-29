using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleTarifa : Detalle
    {
        public DetalleTarifa(Taxi taxi)
        {
            TipoDetalle = "TARIFA";
            Taxi = taxi;
        }

        public override void GenerarCodigoDetalle()
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            CodigoDetalle = random.Next(2000, 2999);
        }
    }
}
