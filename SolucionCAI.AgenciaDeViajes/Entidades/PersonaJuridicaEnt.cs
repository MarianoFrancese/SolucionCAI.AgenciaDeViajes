using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Entidades
{
    public class PersonaJuridicaEnt // : ClienteEnt se saca la herencia para simplificar
    {
        public string RazonSocial { get; set; }
        public string Domicilio { get; set; }
        public long CUIT { get; set; }
        
        //public CuitEnt CUIT { get; set; }
    }
}
