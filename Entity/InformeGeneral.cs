using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class InformeGeneral
    {
        public double CodigoInforme { get; set; }
        public DateTime FechaInforme { get; set; }
        public double GastoTotal { get; set; }
        public double IngresoTotal { get; set; }
        public double GananciaTotal { get; set; }
        public List<Detalle> DetallesTaxis { get; set; }

        public InformeGeneral(List<Detalle> detallesTaxis)
        {
            DetallesTaxis = detallesTaxis;
        }
        public void CalcularGastoTotal()
        {
            var gastos = from detalle in DetallesTaxis where detalle.TipoDetalle.Equals("REPARACION") select detalle;
            GastoTotal = gastos.Sum(X => X.ValorDetalle);
        }
        public void CalcularIngresoTotal()
        {
            var ingresos = from detalle in DetallesTaxis where detalle.TipoDetalle.Equals("TARIFA") select detalle;
            IngresoTotal = ingresos.Sum(X => X.ValorDetalle);
        }
        public void CalcularGananciaTotal()
        {
            GananciaTotal = IngresoTotal - GastoTotal;
        }

    }
}
