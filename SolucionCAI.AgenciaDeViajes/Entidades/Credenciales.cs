using SolucionCAI.AgenciaDeViajes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Entidades
{
    public class Credenciales
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public Credenciales LeerCredencialesDesdeJSON(string rutaArchivo)
        {
            string contenidoJSON = File.ReadAllText(rutaArchivo);
            return JsonSerializer.Deserialize<Credenciales>(contenidoJSON);
        }
    }

    


}

