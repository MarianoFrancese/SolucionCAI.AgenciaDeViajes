﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Entidades
{
    public class ClienteEnt
    {
        public PersonaFisicaEnt PersonaFisica { get; set; }
        public PersonaJuridicaEnt PersonaJuridica { get; set; }
        
        public string CondFiscal { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string MedioPago { get; set; }
    }
}
