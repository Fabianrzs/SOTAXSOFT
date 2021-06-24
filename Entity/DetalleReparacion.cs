using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleReparacion : Detalle
    {
        public DetalleReparacion(string placa)
        {
            TipoDetalle = "REPARACION";
            Placa = placa; 
        }

        public override void GenerarCodigoDetalle()
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            CodigoDetalle = random.Next(1000, 1999);
        }
    }
}
