using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    class DetalleTarifa:Detalle
    {
        public DetalleTarifa(Taxi taxi)
        {
            TipoDetalle = "Tarifa";
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
