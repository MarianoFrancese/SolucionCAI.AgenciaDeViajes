
using Newtonsoft.Json.Linq;
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
                string contenidoDelArchivo = File.ReadAllText("Hoteles.json");
                JArray jsonArray = JArray.Parse(contenidoDelArchivo);
                return jsonArray;
            }
            else
            {
                return new JArray();
            }
        }
    }
}
