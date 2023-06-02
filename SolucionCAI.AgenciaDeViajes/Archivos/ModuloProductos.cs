using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolucionCAI.AgenciaDeViajes.Entidades;
using Newtonsoft.Json;

namespace SolucionCAI.AgenciaDeViajes.Archivos
{
    internal class ModuloProductos
    {
        public List<VueloEnt> jsonVuelos;
        public void TraerLista(string origen, string destino, DateTime fechaSalida, DateTime fechaArribo, int cantPasajeros, char tipoPasajero, char clase)
        {
            if (File.Exists("vuelos.json"))
            {
                string contenidoDelArchivo = File.ReadAllText("vuelos.json");

                if (contenidoDelArchivo != "")
                {
                    jsonVuelos = JsonConvert.DeserializeObject<List<VueloEnt>>(contenidoDelArchivo);
                }
                // Acá hay que parsear la lista y filtrar por los parámetros que nos pasan
                // y devolver la lista filtrada
            }
            else
            {
                jsonVuelos = new List<VueloEnt>();
            }
        }
    }
}
