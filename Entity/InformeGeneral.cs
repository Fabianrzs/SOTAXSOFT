using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class InformeGeneral
    {
        public double CodigoInforme { get; set; }
        public DateTime FechaInforme { get; set; }
        public double GastoTotal { get; set; }
        public double IngresoTotal { get; set; }
        public double GananciaTotal { get; set; }
        public List<Detalle> DetallesTaxis{ get; set; }

        public InformeGeneral(List<Detalle> detallesTaxis)
        {
            DetallesTaxis = detallesTaxis;
        }

        public void CalcularGastoTotal()
        {
            foreach (var i in DetallesTaxis)
            {
                if (i.TipoDetalle.Equals("Reparacion"))
                {
                    GastoTotal += i.ValorDetalle;
                }
            }
        }
        public void CalcularIngresoTotal()
        {
            foreach (var i in DetallesTaxis)
            {
                if (i.TipoDetalle.Equals("Tarifa"))
                {
                    IngresoTotal += i.ValorDetalle;
                }
            }
        }

        public void CalcularGananciaTotal()
        {
            GananciaTotal = IngresoTotal - GastoTotal;
        }
    }
}
