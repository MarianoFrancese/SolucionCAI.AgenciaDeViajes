using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolucionCAI.AgenciaDeViajes.Entidades;
using Newtonsoft.Json;
using System.Reflection.Metadata.Ecma335;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace SolucionCAI.AgenciaDeViajes.Archivos
{
    public class ModuloProductos
    {
        public static List<VueloEnt> ListaVuelos(string origen, string destino, DateTime fechaPartida, int cantPasajeros, string tipoPasajero, string clase)
        {


            if (File.Exists("vuelos.json"))
            {
                string contenidoDelArchivo = File.ReadAllText("vuelos.json");

                JObject jsonObject = JObject.Parse(contenidoDelArchivo);

                //List<dynamic> vuelosJson = JsonConvert.DeserializeObject<List<dynamic>>(contenidoDelArchivo);          
                List<VueloEnt> vuelosFiltrados = new List<VueloEnt>();

                foreach (JObject vueloJson in jsonObject["vuelos"])
                {
                    string origenjson = (string)vueloJson["origen"];
                    string destinojson = (string)vueloJson["destino"];
                    string fechapartidajson = (string)vueloJson["fecha de partida"];
                    string cantpjson = (string)vueloJson["cantidad pasajeros"];
                    string tipopjson = (string)vueloJson["tipo de pasajero"];
                    string clasejson = (string)vueloJson["clase"];

                    if (origenjson == origen && destinojson == destino && DateTime.Parse(fechapartidajson) == fechaPartida && Int64.Parse(cantpjson) == cantPasajeros && tipopjson == tipoPasajero && clasejson == clase)
                    {
                        VueloEnt vuelo = new VueloEnt
                        {
                            Codigo = (string)vueloJson["codigo"],
                            Origen = origenjson,
                            Destino = destinojson,
                            FechaSalida = DateTime.Parse(fechapartidajson),
                            // Add more properties as needed
                            FechaArribo = (DateTime)vueloJson["fecha de llegada"],
                            TiempoVuelo = TimeSpan.Parse((string)vueloJson["duracion"]),
                            Aerolinea = (string)vueloJson["aerolinea"],
                            Tarifas = JsonConvert.DeserializeObject<List<TarifaEnt>>(vueloJson["tarifas"].ToString())
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

    }
}


