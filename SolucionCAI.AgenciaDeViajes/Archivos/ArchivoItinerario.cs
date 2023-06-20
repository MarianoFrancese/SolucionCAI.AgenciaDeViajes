
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
    public class ArchivoItinerario
    {
        public static JArray LeerItinerario()
        {
            if (File.Exists("Itinerarios.json"))
            {
                List<ItinerarioEnt> itinerarios = new List<ItinerarioEnt>();
                string contenidoDelArchivo = File.ReadAllText("Itinerarios.json");
                if (string.IsNullOrEmpty(contenidoDelArchivo))
                {
                    JArray jArray = new JArray();
                    return jArray;
                }
                else
                {
                    JArray jsonArray = JArray.Parse(contenidoDelArchivo);
                    return jsonArray;
                }
               

                //foreach (JObject json in jsonArray)
                //{
                //    foreach (JObject disponibilidad in json["Disponibilidad"]["HabitacionFechaDisp"])
                //    {
                //        Guid Uid = Guid.NewGuid();

                //        disponibilidad["Uid"] = Uid.ToString();

                //    }

                //}
                //string contenido = JsonConvert.SerializeObject(jsonArray, Formatting.Indented);
                //File.WriteAllText("Hoteles.json", contenido);
                //var mensaje = "Grabado";
                //return jsonArray;

            }
            else
            {
                return new JArray();
            }
        }

        public static void GrabarItinerario(JArray itinerarios)
        {
            string contenido = JsonConvert.SerializeObject(itinerarios, Formatting.Indented);
            File.WriteAllText("Itinerarios.json", contenido);
        }

        public static void GrabarItinerarioString(string itinerarios)
        {
            File.WriteAllText("Itinerarios.json", itinerarios);
        }
    } 
}
