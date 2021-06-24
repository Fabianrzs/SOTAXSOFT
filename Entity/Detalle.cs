using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Detalle
    {
        public double CodigoDetalle { get; set; }
        public string TipoDetalle { get; set; }
        public DateTime FechaDetalle { get; set; }
        public double ValorDetalle { get; set; }
        public string Descripcion { get; set; }
        public string Placa { get; set; }

        public abstract void GenerarCodigoDetalle();
    }
}
