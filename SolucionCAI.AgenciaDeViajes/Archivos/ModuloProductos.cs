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
        //public static List<VueloEnt> ListaVuelos(string origen, string destino, DateTime fechaPartida, int cantPasajeros, string tipoPasajero, string clase)
        //{
            

        //    if (File.Exists("vuelos.json"))
        //    {
        //        string contenidoDelArchivo = File.ReadAllText("vuelos.json");

        //        JObject jsonObject = JObject.Parse(contenidoDelArchivo);

        //        //List<dynamic> vuelosJson = JsonConvert.DeserializeObject<List<dynamic>>(contenidoDelArchivo);          
        //        List<VueloEnt> vuelosFiltrados = new List<VueloEnt>();

        //        foreach (var contenido in contenidoDelArchivo)
        //        {
        //            string origenjson = (string)jsonObject["origen"];
        //            string destinojson = (string)jsonObject["destino"];
        //            string fechapartidajson = (string)jsonObject["fecha de partida"];
        //            string cantpjson = (string)jsonObject["cantidad pasajeros"];
        //            string tipopjson = (string)jsonObject["tipo de pasajero"];
        //            string clasejson = (string)jsonObject["clase"];

        //            if (origenjson==origen && destinojson==destino && DateTime.Parse(fechapartidajson)==fechaPartida && Int64.Parse(cantpjson)==cantPasajeros && tipopjson==tipoPasajero && clasejson==clase)
        //            {

                        
        //            }

        //        }
        //    }
        //    else
        //    {
        //        jsonVuelos = new List<VueloEnt>();
        //        return jsonVuelos;
        //    }
        //}
        
    }
}


