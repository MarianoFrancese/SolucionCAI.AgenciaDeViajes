using SolucionCAI.AgenciaDeViajes.Archivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Entidades
{
    public class HotelEnt
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string CodigoCiudad { get; set; }
        public int Calificacion { get; set; }
        public DireccionEnt Direccion { get; set; }
        public DisponibilidadHabEnt Disponibilidad { get; set; }
        public Guid Uid { get; set; }

        public HotelEnt ObtenerHotelPorId(Guid uid)
        {
            HotelEnt hotel = new HotelEnt();
            hotel = ModuloProductos.ObtenerHotelPorID(uid);
            return hotel;
        }

        public List<DisponibilidadHabEnt> Disponibles(DateTime desde, DateTime hasta)
        {
            //var disponibles = new List<DisponibilidadHabEnt>();
            //foreach(var disponibilidad in Disponibilidad)
            //{
            //    if(disponibilidad.Disponible(desde, hasta))
            //    {
            //        disponibles.Add(disponibilidad);
            //    }
            //}
            return null;
        }
    }
}
