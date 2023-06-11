using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using SolucionCAI.AgenciaDeViajes.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Archivos
{
    public class ModuloItinerario
    {
        public static List<ItinerarioEnt> ListaItinerario(string nroseguimiento)
        {

            if (File.Exists("Itinerarios.json"))
            {
                Console.WriteLine("El archivo existe");
                string contenidoDelArchivo = File.ReadAllText("Itinerarios.json");

                JArray jsonArray = JArray.Parse(contenidoDelArchivo);

                List<ItinerarioEnt> itinerariosFiltrados = new List<ItinerarioEnt>();

                foreach (JObject itinerarioJson in jsonArray)
                {
                    string nrosegjson = (string)itinerarioJson["Presupuestos"][0]["NroSeguimiento"];
                    string estadojson = (string)itinerarioJson["Estado"];
                    

                    if (nrosegjson == nroseguimiento && estadojson == "PreReserva")
                    {
                        var presupuestos = JsonConvert.DeserializeObject<List<PresupuestoEnt>>(itinerarioJson["Presupuestos"].ToString());
                        var cliente = JsonConvert.DeserializeObject<List<ClienteEnt>>(itinerarioJson["Cliente"].ToString());
                        
                        ItinerarioEnt itinerario = new ItinerarioEnt
                        {
                            PresupuestosList = JsonConvert.DeserializeObject<List<PresupuestoEnt>>(itinerarioJson["Presupuestos"].ToString()),
                            Cliente = JsonConvert.DeserializeObject<List<ClienteEnt>>(itinerarioJson["Cliente"].ToString()),                          
                            MedioPago = (string)itinerarioJson["Medio de Pago"],
                                                       
                        };
                        Console.WriteLine(itinerario.PresupuestosList);
                        Console.WriteLine(itinerario.Cliente);
                        

                        itinerariosFiltrados.Add(itinerario);

                    }

                }
                return itinerariosFiltrados;
            }
            else
            {
                return new List<ItinerarioEnt>();
            }
        }

    }
}

