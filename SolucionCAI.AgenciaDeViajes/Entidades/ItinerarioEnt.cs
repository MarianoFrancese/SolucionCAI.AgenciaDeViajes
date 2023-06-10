using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Entidades
{
    public class ItinerarioEnt // : PresupuestoEnt //no deberia ser heredado
    {
        public List<PresupuestoEnt> PresupuestosList { get; set; } //se agrego presupuesto como atributo de itinerario
        public int nroseg { get { return TraerNumSeguimiento; } }
        public string Estado { get; set; }
        public bool TipoCliente { get; set; }
        public PersonaFisicaEnt PersonaFisica { get; set;}
        public PersonaJuridicaEnt PersonaJuridica { get; set; }
        public List<PasajeroEnt> Pasajeros { get; set; }
        public string MedioPago { get; set; }
        
        //public decimal DescuentoMP { get; }
        public string EstadoPago { get; set; }

        public int TraerNumSeguimiento (PresupuestoEnt presupuesto) 
        {
            int nroseguimiento = presupuesto.NroSeguimiento;
            return nroseguimiento;
        }

    }
}
