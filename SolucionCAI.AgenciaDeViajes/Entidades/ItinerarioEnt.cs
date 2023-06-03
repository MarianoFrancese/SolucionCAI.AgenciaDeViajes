using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Entidades
{
    internal class ItinerarioEnt : PresupuestoEnt
    {
        public string Estado { get; set; }
        public bool TipoCliente { get; set; }
        public PersonaFisicaEnt PersonaFisica { get; set;}
        public PersonaJuridicaEnt PersonaJuridica { get; set; }
        public List<PasajeroEnt> Pasajeros { get; set; }
        public string MedioPago { get; set; }
        public decimal DescuentoMP { get; }
        public string EstadoPago { get; set; }
    }
}
