
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SolucionCAI.AgenciaDeViajes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Archivos
{
    public class ArchivoVuelos
    {
        public static JArray LeerVuelos()
        {
            if (File.Exists("Vuelos.json"))
            {
                List<VueloEnt> vuelos = new List<VueloEnt>();
                string contenidoDelArchivo = File.ReadAllText("C:\\Users\\mfrancese\\source\\repos\\SolucionCAI.AgenciaDeViajes\\SolucionCAI.AgenciaDeViajes\\Vuelos.json");
                JArray jsonArray = JArray.Parse(contenidoDelArchivo);
                //foreach (JObject json in jsonArray)
                //{
                //    foreach (JObject tarifa in json["Tarifas"])
                //    {
                //        Guid Uid = Guid.NewGuid();

                //        tarifa["Uid"] = Uid.ToString();
                //    }
                //}
                //string contenido = JsonConvert.SerializeObject(jsonArray, Formatting.Indented);
                //File.WriteAllText("Vuelos.json", contenido);
                //var mensaje = "Grabado";
                return jsonArray;

            }
            else
            {
                return new JArray();
            }
        }
    } 
}
