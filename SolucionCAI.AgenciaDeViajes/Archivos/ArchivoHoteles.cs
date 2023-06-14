
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Archivos
{
    internal class ArchivoHoteles
    {
        public static JArray LeerHoteles()
        {
            if (File.Exists("HotelesEnt.json"))
            {
                string contenidoDelArchivo = File.ReadAllText("HotelesEnt.json");
                Console.WriteLine("El archivo existe");

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
