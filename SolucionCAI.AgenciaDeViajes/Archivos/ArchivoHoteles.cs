
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
    public class ArchivoHoteles
    {
        public static JArray LeerHoteles()
        {
            if (File.Exists("Hoteles.json"))
            {
                List<HotelEnt> hoteles = new List<HotelEnt>();
                string contenidoDelArchivo = File.ReadAllText("Hoteles.json");
                JArray jsonArray = JArray.Parse(contenidoDelArchivo);
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
                return jsonArray;

            }
            else
            {
                return new JArray();
            }
        }
    } 
}
