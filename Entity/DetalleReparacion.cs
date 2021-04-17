using System;
using System.Collections.Generic;
using System.Text;


namespace Entity
{
    public class DetalleReparacion : Detalle
    {
        public DetalleReparacion(Taxi taxi)
        {
            TipoDetalle = "Reparacion";
            Taxi = taxi;
        }

        public override void GenerarCodigoDetalle()
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            CodigoDetalle = random.Next(1000, 1999);
        }
    }
}