﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SolucionCAI.AgenciaDeViajes.Entidades;
using System;
using System.Globalization;
using System.IO;

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
                        Console.WriteLine(vuelo.Tarifas);

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
            if (File.Exists("Hoteles.json"))
            {
                string contenidoDelArchivo = File.ReadAllText("Hoteles.json");
                Console.WriteLine("El archivo existe");

                JArray jsonArray = JArray.Parse(contenidoDelArchivo);

                List<HotelEnt> hotelesFiltrados = new List<HotelEnt>();

                foreach (JObject hotelJson in jsonArray)
                {
                    string codigoJson = (string)hotelJson["Codigo"];
                    string nombreJson = (string)hotelJson["Nombre"];
                    string ciudadJson = (string)hotelJson["CodigoDeCiudad"];
                    DateTime fechaEntradaJson = DateTime.ParseExact(hotelJson["HabitacionFechaDis"]["FechaEntradaHab"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture); //corregir esto ya que hay 1 sola fecha(FechaHab)
                    DateTime fechaSalidaJson = DateTime.ParseExact(hotelJson["HabitacionFechaDis"]["FechaSalidaHab"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);//corregir esto ya que hay 1 sola fecha(FechaHab)
                    Console.WriteLine(fechaSalidaJson);
                    string calificacionJson = (string)hotelJson["Calificacion"];
                    string tipoHabitacionJson = (string)hotelJson["Disponibilidad"][0]["Nombre"];
                    int capacidadJson = Convert.ToInt32(hotelJson["Disponibilidad"][0]["Capacidad"]);

                    //foreach (var habitacionFecha in hotelJson["Disponibilidad"][0]["HabitacionFechaDis"][0])
                    //{
                    //    Console.WriteLine(habitacionFecha);
                    //    //if (disponibilidadJson["Nombre"].ToString() == tipoHabitacion)
                    //    //{
                    //    //    capacidadJson = Convert.ToInt32(disponibilidadJson["Capacidad"]);
                    //    //}
                    //}
                    int cantHab = Convert.ToInt32(hotelJson["HabitacionFechaDis"]["CantHab"]);
                    int disponibilidad = cantHab * capacidadJson; 


                    if (ciudadJson == ciudad && fechaEntradaJson >= Convert.ToDateTime(fechaEntrada) && fechaSalidaJson <= Convert.ToDateTime(fechaSalida) && disponibilidad >= cantHuespedes && tipoHabitacionJson == tipoHabitacion && cantHab != 0)
                    {
                        var listaDisponibilidad = JsonConvert.DeserializeObject<List<DisponibilidadHabEnt>>(hotelJson["Disponibilidad"].ToString());
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

                        HabitacionFechaEnt habitacionFecha = new HabitacionFechaEnt
                        {
                            FechaEntHab = fechaEntradaJson,
                            FechaSalHab = fechaSalidaJson,
                            CantHab = cantHab
                        };

                        HotelEnt hotel = new HotelEnt
                        {
                            Codigo = codigoJson,
                            Nombre = nombreJson,
                            CodigoCiudad = ciudadJson,
                            Calificacion = Convert.ToInt32(calificacionJson),
                            Direccion = direccion,
                            Disponibilidad = listaDisponibilidad,
                            HabitacionFecha = habitacionFecha
                        };
                        Console.WriteLine(hotel.Disponibilidad);
                        hotelesFiltrados.Add(hotel);

                    }

                }
                return hotelesFiltrados;
            }
            else
            {
                return new List<HotelEnt>();
            }
        }

    }
}


