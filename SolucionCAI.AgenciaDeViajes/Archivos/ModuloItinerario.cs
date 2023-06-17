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
        public static List<PresupuestoEnt> ListaPresupuestos(string nroseguimiento)
        {

            if (File.Exists("Presupuestos.json"))
            {
                Console.WriteLine("El archivo existe");
                string contenidoDelArchivoP = File.ReadAllText("Presupuestos.json");

                JArray jsonArrayP = JArray.Parse(contenidoDelArchivoP);

                List<PresupuestoEnt> presupuestosFiltrados = new List<PresupuestoEnt>();

                foreach (JObject presupuestoJson in jsonArrayP)
                {
                    string nrosegjson = (string)presupuestoJson["NroSeguimiento"];



                    if (nrosegjson == nroseguimiento)
                    {
                        var productos = JsonConvert.DeserializeObject<List<ProductoLineaEnt>>(presupuestoJson["Productos"].ToString());

                        PresupuestoEnt presupuesto = new PresupuestoEnt
                        {
                            NroSeguimiento = Convert.ToInt32(presupuestoJson["NroSeguimiento"]),
                            Productos = productos, //JsonConvert.DeserializeObject<List<ProductoLineaEnt>>(presupuestoJson["Productos"].ToString()),
                            Descripcion = (string)presupuestoJson["Descripcion"],
                            Total = Convert.ToInt32(presupuestoJson["Total"])

                        };
                        Console.WriteLine(presupuesto.Productos);


                        presupuestosFiltrados.Add(presupuesto);

                    }

                }
                return presupuestosFiltrados;
            }
            else
            {
                Console.WriteLine("El archivo no existe");
                return new List<PresupuestoEnt>();
            }
        }
        public static List<ItinerarioEnt> ListaItinerarioPre(string nroseguimiento)
        {

            if (File.Exists("Itinerarios.json"))
            {
                Console.WriteLine("El archivo existe");
                string contenidoDelArchivo = File.ReadAllText("Itinerarios.json");

                JArray jsonArray = JArray.Parse(contenidoDelArchivo);

                List<ItinerarioEnt> itinerariosFiltrados = new List<ItinerarioEnt>();

                foreach (JObject itinerarioJson in jsonArray)
                {
                    string nrosegjson = (string)itinerarioJson["Presupuesto"]["NroSeguimiento"];
                    string estadojson = (string)itinerarioJson["Estado"];
                    

                    if (nrosegjson == nroseguimiento && estadojson == "PreReserva") //funciona ok, busca ambas condiciones
                    {
                        var presupuestos = JsonConvert.DeserializeObject<PresupuestoEnt>(itinerarioJson["Presupuestos"].ToString());
                        var cliente = JsonConvert.DeserializeObject<ClienteEnt>(itinerarioJson["Cliente"].ToString());
                        
                        ItinerarioEnt itinerario = new ItinerarioEnt
                        {
                            PresupuestosList = presupuestos, //JsonConvert.DeserializeObject<PresupuestoEnt>(itinerarioJson["Presupuestos"].ToString()),
                            Cliente = cliente,//JsonConvert.DeserializeObject<List<ClienteEnt>>(itinerarioJson["Cliente"].ToString()),                          
                            
                                                       
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
                Console.WriteLine("El archivo no existe");
                return new List<ItinerarioEnt>();
            }
        }
        public static List<ItinerarioEnt> ListaItinerarioReserva(string nroseguimiento)
        {

            if (File.Exists("Itinerarios.json"))
            {
                Console.WriteLine("El archivo existe");
                string contenidoDelArchivo = File.ReadAllText("Itinerarios.json");

                JArray jsonArray = JArray.Parse(contenidoDelArchivo);

                List<ItinerarioEnt> itinerariosFiltrados = new List<ItinerarioEnt>();

                foreach (JObject itinerarioJson in jsonArray)
                {
                    string nrosegjson = (string)itinerarioJson["Presupuesto"]["NroSeguimiento"];
                    string estadojson = (string)itinerarioJson["Estado"];
                    

                    if (nrosegjson == nroseguimiento && estadojson == "Reserva") //funciona ok, busca ambas condiciones
                    {
                        var presupuestos = JsonConvert.DeserializeObject<PresupuestoEnt>(itinerarioJson["Presupuestos"].ToString());
                        var cliente = JsonConvert.DeserializeObject<ClienteEnt>(itinerarioJson["Cliente"].ToString());

                        ItinerarioEnt itinerario = new ItinerarioEnt
                        {
                            PresupuestosList = presupuestos, //JsonConvert.DeserializeObject<PresupuestoEnt>(itinerarioJson["Presupuestos"].ToString()),
                            Cliente = cliente,//JsonConvert.DeserializeObject<List<ClienteEnt>>(itinerarioJson["Cliente"].ToString()),                          
                            EstadoPago = (string)itinerarioJson["Estado de Pago"],

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
                Console.WriteLine("El archivo no existe");
                return new List<ItinerarioEnt>();
            }
        }
               
    }
}

