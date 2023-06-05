using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SolucionCAI.AgenciaDeViajes.Entidades;
using System.Globalization;
using System.IO;

namespace SolucionCAI.AgenciaDeViajes.Archivos
{
    public class ModuloProductos
    {   //Q: Why cant i get file path to work?
        //A: Because the file is not in the same folder as the executable.
        //Q: Which is the executable?
        //A: The .exe file that is created when you build the project.
        //Q: But if I have it in this solution project?
        //A: It doesn't matter. The executable is created in a different folder.
        //Q: So how do I get the file path to work?
        //A: You have to copy the file to the same folder as the executable.
        //Q: Is there any way to access to the file when having it in the solution project?
        //A: Yes, you can use the "Copy to Output Directory" property of the file.
        //Q: How do I do that?

        public static List<VueloEnt> ListaVuelos(string origen, string destino, string fechaPartida, int cantPasajeros, string tipoPasajero, string clase)
        {

            if (File.Exists("C:\\Users\\mfrancese\\source\\repos\\SolucionCAI.AgenciaDeViajes\\SolucionCAI.AgenciaDeViajes\\Archivos\\VuelosEnt.json"))
            {
                Console.WriteLine("El archivo existe");
                string contenidoDelArchivo = File.ReadAllText("C:\\Users\\mfrancese\\source\\repos\\SolucionCAI.AgenciaDeViajes\\SolucionCAI.AgenciaDeViajes\\Archivos\\VuelosEnt.json");

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

                    if (origenjson == origen && destinojson == destino && fechapartidajson == fechaPartida && Int64.Parse(cantpjson) >= cantPasajeros && tipopjson == tipoPasajero && clasejson == clase)
                    {
                        VueloEnt vuelo = new VueloEnt
                        {
                            Codigo = (string)vueloJson["Codigo"],
                            Origen = origenjson,
                            Destino = destinojson,
                            FechaSalida = DateTime.ParseExact(fechapartidajson, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                            // Agregar más propiedades
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

    }
}


