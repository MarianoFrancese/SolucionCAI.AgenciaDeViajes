using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Entidades
{
    public class PersonaFisicaEnt // : ClienteEnt no hereda para simplificar
    {
        public string Nombre { get; set; }
        
        public string DNI { get; set; }
        public string CUIL { get; set; }
        
        //public CuilEnt CUIL { get; set; }
    }
}
