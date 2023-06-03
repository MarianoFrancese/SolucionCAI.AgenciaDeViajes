using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Entidades
{
    internal class PersonaFisicaEnt : ClienteEnt
    {
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public CuilEnt CUIL { get; set; }
    }
}
