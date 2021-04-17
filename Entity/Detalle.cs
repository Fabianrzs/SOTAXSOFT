﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public abstract class Detalle
    {
        public double CodigoDetalle { get; set; }
        public string TipoDetalle { get; set; }
        public DateTime FechaDetalle { get; set; }
        public double ValorDetalle { get; set; }


        public void GenerarCodigoDetalle()
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            CodigoDetalle = random.Next(1000, 9999);
        }


    }
}