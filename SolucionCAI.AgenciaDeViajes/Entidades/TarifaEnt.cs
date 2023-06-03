using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Entidades
{
    public class TarifaEnt
    {
        public char Clase { get; set; }
        public char TipoPasajero { get; set; }
        public decimal Precio { get; set; }
        public int Disponibilidad { get; set; }
    }
}
