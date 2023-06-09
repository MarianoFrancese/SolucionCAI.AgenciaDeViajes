using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Entidades
{
    public class PersonaJuridicaEnt : ClienteEnt
    {
        public string Domicilio { get; set; }
        public CuitEnt CUIT { get; set; }
    }
}
