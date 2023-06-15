using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SolucionCAI.AgenciaDeViajes.Entidades;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SolucionCAI.AgenciaDeViajes.Archivos
{
    public class ModuloProductos
    {
        public static List<VueloEnt> ListaVuelos(string origen, string destino, string fechaPartida, int cantPasajeros, string tipoPasajero, string clase)
        {

            if (File.Exists("Vuelos.json"))
            {
                string contenidoDelArchivo = File.ReadAllText("Vuelos.json");
                Console.WriteLine("El archivo existe");
                JArray jsonArray = JArray.Parse(contenidoDelArchivo);

                List<VueloEnt> vuelosFiltrados = new List<VueloEnt>();

                foreach (JObject vueloJson in jsonArray)
                {
                    string origenjson = (string)vueloJson["Origen"];
                    string destinojson = (string)vueloJson["Destino"];
                    string fechapartidajson = (string)vueloJson["FechaSalida"];
                    string cantpjson = (string)vueloJson["Tarifas"][0]["Disponibilidad"].ToString();
                    string tipopjson = (string)vueloJson["Tarifas"][0]["TipoPasajero"];
                    string clasejson = (string)vueloJson["Tarifas"][0]["Clase"];
                    string preciojson = (string)vueloJson["Tarifas"][0]["Precio"].ToString();

                    if (origenjson == origen && destinojson == destino && fechapartidajson == fechaPartida && Int64.Parse(cantpjson) >= cantPasajeros && tipopjson == tipoPasajero && clasejson == clase)
                    {
                        var tarifas = JsonConvert.DeserializeObject<List<TarifaEnt>>(vueloJson["Tarifas"].ToString());
                        VueloEnt vuelo = new VueloEnt
                        {
                            Codigo = (string)vueloJson["Codigo"],
                            Origen = origenjson,
                            Destino = destinojson,
                            FechaSalida = DateTime.ParseExact(fechapartidajson, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                            FechaArribo = DateTime.ParseExact((string)vueloJson["FechaArribo"], "dd/MM/yyyy", CultureInfo.InvariantCulture),
                            TiempoVuelo = TimeSpan.Parse((string)vueloJson["TiempoVuelo"]),
                            Aerolinea = (string)vueloJson["Aerolinea"],
                            Tarifas = JsonConvert.DeserializeObject<List<TarifaEnt>>(vueloJson["Tarifas"].ToString())
                        };

                        vuelosFiltrados.Add(vuelo);

                    }

                }
                return vuelosFiltrados;
            }
            else
            {
                return new List<VueloEnt>();
            }
        }

        public static List<HotelEnt> ListaHoteles(string ciudad, string fechaEntrada, string fechaSalida, int cantHuespedes, string tipoHabitacion)
        {
            JArray jsonArray = ArchivoHoteles.LeerHoteles();
            if(jsonArray.Count > 0)
            {
                Console.WriteLine("El archivo existe");

                List<HotelEnt> hotelesFiltrados = new List<HotelEnt>();
                DateTime fechaE = DateTime.ParseExact(fechaEntrada, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime fechaS = DateTime.ParseExact(fechaSalida, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                foreach (JObject hotelJson in jsonArray)
                {
                    List<DateTime> fechasJson = new List<DateTime>();
                    List<DateTime> fechasFiltro = new List<DateTime>();

                    foreach (var habitacionFecha in hotelJson["Disponibilidad"][0]["HabitacionFechaDis"])
                    {
                        DateTime fechaJson = DateTime.ParseExact(habitacionFecha["FechaHab"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        fechasJson.Add(fechaJson);
                    }
                    string codigoJson = (string)hotelJson["Codigo"];
                    string nombreJson = (string)hotelJson["Nombre"];
                    string ciudadJson = (string)hotelJson["CodigoDeCiudad"];                      
                    string calificacionJson = (string)hotelJson["Calificacion"];
                    string tipoHabitacionJson = (string)hotelJson["Disponibilidad"][0]["Nombre"];
                    int capacidadJson = Convert.ToInt32(hotelJson["Disponibilidad"][0]["Capacidad"]);
                        

                    while (fechaE <= fechaS)
                    {
                        fechasFiltro.Add(fechaE);
                        fechaE = fechaE.AddDays(1);
                    }

                    bool compararFechas = fechasFiltro.All(value => fechasJson.Contains(value));

                    if (ciudadJson == ciudad && compararFechas && capacidadJson >= cantHuespedes && tipoHabitacionJson == tipoHabitacion)
                    {
                        var listaDisponibilidad = JsonConvert.DeserializeObject<List<DisponibilidadHabEnt>>(hotelJson["Disponibilidad"].ToString());
                        List<HabitacionFechaEnt> listaHabitaciones = new List<HabitacionFechaEnt>();
                        // Ver como manejar la disponibilidad de la habitacion con la cantidad de habitaciones
                        //IMPORTANTE!!
                        DireccionEnt direccion = new DireccionEnt
                        {
                            Calle = hotelJson["Direccion"]["Calle"].ToString(),
                            Numero = Convert.ToInt32(hotelJson["Direccion"]["Numero"]),
                            CP = Convert.ToInt32(hotelJson["Direccion"]["CP"]),
                            Latitud = Convert.ToDecimal(hotelJson["Direccion"]["Latitud"]),
                            Longitud = Convert.ToDecimal(hotelJson["Direccion"]["Longitud"])
                        };

                        HabitacionFechaEnt habitacionFechaEnt = new HabitacionFechaEnt
                        {
                            FechaEntHab = fechaE,
                            //CantHab = 1
                        };
                        listaHabitaciones.Add(habitacionFechaEnt);
                        listaDisponibilidad[0].HabitacionFechaDisp = listaHabitaciones;

                        HotelEnt hotel = new HotelEnt
                        {
                            Codigo = codigoJson,
                            Nombre = nombreJson,
                            CodigoCiudad = ciudadJson,
                            Calificacion = Convert.ToInt32(calificacionJson),
                            Direccion = direccion,
                            Disponibilidad = listaDisponibilidad,
                        };

                        if(hotelesFiltrados.Count == 0)
                        {
                            hotelesFiltrados.Add(hotel);
                        }
                        else if(hotelesFiltrados.Count > 0 && hotel.Codigo != hotelesFiltrados[0].Codigo)
                        {
                            foreach(var codigo in hotelesFiltrados[0].Codigo)
                            {
                                if(codigo.ToString() != hotel.Codigo)
                                {
                                    hotelesFiltrados.Add(hotel);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("El hotel ya existe");
                        }

                    }

                }
                return hotelesFiltrados;

            }
            else
            {
                Console.WriteLine("El archivo no existe");
                return new List<HotelEnt>();
            }
        }

    }
}


