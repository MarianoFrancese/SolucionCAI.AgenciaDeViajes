using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Entidades
{
    public class TarifaEnt
    {
        public string Clase { get; set; }
        public string TipoPasajero { get; set; }
        public decimal Precio { get; set; }
        public int Disponibilidad { get; set; }
    }
}
