using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Entidades
{
    public class ItinerarioEnt 
    {
        public List<PresupuestoEnt> PresupuestosList { get; set; } //se agrego presupuesto como atributo de itinerario
       
        //public int nroseg { get { return TraerNumSeguimiento; } }
        public string Estado { get; set; }
        public List <ClienteEnt> Cliente { get; set; } 
        public string MedioPago { get; set; } //agregar a cliente
        public string EstadoPago { get; set; }


        //public PersonaFisicaEnt PersonaFisica { get; set;}
        //public PersonaJuridicaEnt PersonaJuridica { get; set; }

        // public List<PasajeroEnt> Pasajeros { get; set; } //los pasajeros estarian dentro de vuelo, no de itinerario


        //public decimal DescuentoMP { get; }


        //public int TraerNumSeguimiento (PresupuestoEnt presupuesto) 
        //{
        //    int nroseguimiento = presupuesto.NroSeguimiento;
        //    return nroseguimiento;
        //}

    }
}
