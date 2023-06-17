using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Entidades
{
    public class ItinerarioEnt 
    {
        public PresupuestoEnt PresupuestosList { get; set; } 
               
        public string Estado { get; set; }
        public ClienteEnt Cliente { get; set; } 
        
        public string EstadoPago { get; set; }

               

    }
}
