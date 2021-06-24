using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleTarifa : Detalle
    {
        public DetalleTarifa(string placa)
        {
            TipoDetalle = "TARIFA";
            Placa = placa;
        }

        public override void GenerarCodigoDetalle()
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            CodigoDetalle = random.Next(2000, 2999);
        }
    }
}
