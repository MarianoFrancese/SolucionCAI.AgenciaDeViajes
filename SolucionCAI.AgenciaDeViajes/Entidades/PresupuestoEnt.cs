using System;
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
        public Decimal Total { get { return CalcularTotalPresupuesto(Productos); } }

        public decimal CalcularTotalPresupuesto(List<ProductoLineaEnt> productos)
        {
            decimal totalPresupuesto = 0;
            foreach (var producto in productos)
            {
                totalPresupuesto += producto.TotalProd;
            }
            return totalPresupuesto;
        }

        public int CalcularNroSeguimiento()
        {
            int nroSeguimiento = NroSeguimiento + 1;
            return nroSeguimiento;
        }
    }
}
