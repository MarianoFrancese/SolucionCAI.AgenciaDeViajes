using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Entidades
{
    public class ItinerarioEnt 
    {
        public PresupuestoEnt Presupuesto { get; set; } 
               
        public string Estado { get; set; }
        public ClienteEnt Cliente { get; set; } 
        
        public string EstadoPago { get; set; }

        internal ProductoLineaEnt VueloDeTarifa(TarifaEnt tarifa)
        {
            foreach (var productoLinea in Presupuesto.Productos)
            {
                if (productoLinea.ProductoV != null)
                {
                    if (productoLinea.ProductoV.Tarifas[0] == tarifa)
                    {
                        return productoLinea;
                    }
                }
            }

            //acá no debería llegar nunca.
            throw new Exception("La tarifa no está en el itinerario.");
        }

        internal string PuedeReservar()
        {
            foreach (var productoLinea in Presupuesto.Productos)
            {
                if (productoLinea.ProductoV.Tarifas[0].Pasajeros.Count != productoLinea.Cantidad)
                {
                    return "La tarifa ... del vuelo ... no tiene todos sus pasajeros asignados.";
                }
            }

            //si hay mas validaciones poner acá.


            return null;
        }
    }
}
