﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Entidades
{
    public class PresupuestoEnt
    {
        public int NroSeguimiento { get; set; }
        public List<ProductoLineaEnt> Productos { get; set; }
        public Decimal Total { get; set; }
    }
}
