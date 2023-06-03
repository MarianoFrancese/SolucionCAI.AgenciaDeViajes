using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Entidades
{
    public class DireccionEnt
    {
        public string Calle { get; set; }
        public int Numero { get; set; }
        public int CP { get; set; }
        public Decimal Latitud { get; set; }
        public Decimal Longitud { get; set; }
    }
}
