using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Entidades
{
    public class HotelEnt
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get { return MostrarDescripcion(); } }
        public string CodigoCiudad { get; set; }
        public int Calificacion { get; set; }
        public DireccionEnt Direccion { get; set; }
        public List<DisponibilidadHabEnt> Disponibilidad { get; set; }

        public string MostrarDescripcion()
        {
            return $"Codigo: {Codigo} - Hotel {Nombre}";
        }
    }
}
