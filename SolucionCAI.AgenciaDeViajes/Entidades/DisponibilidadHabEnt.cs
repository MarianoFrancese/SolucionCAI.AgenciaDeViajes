using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Entidades
{
    public class DisponibilidadHabEnt
    {
        public string Nombre { get; set; }
        public decimal TarifaHab { get; set; }
        public int Capacidad { get; set; }
        public int Adultos { get; set; }
        public int Menores { get; set; }
        public int Infantes { get; set; }
        public List<HabitacionFechaEnt> HabitacionFechaDisp { get; set; }
    }
}
