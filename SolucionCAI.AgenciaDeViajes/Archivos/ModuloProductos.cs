using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolucionCAI.AgenciaDeViajes.Entidades;
using Newtonsoft.Json;
using System.Reflection.Metadata.Ecma335;

namespace SolucionCAI.AgenciaDeViajes.Archivos
{
    public class ModuloProductos
    {
        public static List<VueloEnt> ListaVuelos(string origen, string destino, DateTime fechaPartida, int cantPasajeros, string tipoPasajero, string clase)
        {
            // Q: How can I filter all the variables i set as parameters, in the JSON file?
            // A
            if (File.Exists("vuelos.json"))
            {
                string contenidoDelArchivo = File.ReadAllText("vuelos.json");

                dynamic jsonData = JsonConvert.DeserializeObject<List<VueloEnt>>(contenidoDelArchivo);




                if (contenidoDelArchivo != "")
                {
                    foreach (origen in jsonData["origen"] && destino in jsonData["destino"] && fechaPartida in ["fecha partida"] )
                    {
                        int jsonValue = origen;

                    }
                    jsonVuelos = JsonConvert.DeserializeObject<List<VueloEnt>>(contenidoDelArchivo);
                    return jsonVuelos;
                }   
                // Acá hay que parsear la lista y filtrar por los parámetros que nos pasan
                // y devolver la lista filtrada
            }
            else
            {
                jsonVuelos = new List<VueloEnt>();
                return jsonVuelos;
            }
        }
        
    }
}


