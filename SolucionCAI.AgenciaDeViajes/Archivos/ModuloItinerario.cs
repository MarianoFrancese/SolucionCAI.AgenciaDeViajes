using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using SolucionCAI.AgenciaDeViajes.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Archivos
{
    public class ModuloItinerario
    {
        public static List<PresupuestoEnt> ListaPresupuestos(string nroseguimiento)
        {

            if (File.Exists("Presupuestos.json"))
            {
                Console.WriteLine("El archivo existe");
                string contenidoDelArchivoP = File.ReadAllText("Presupuestos.json");

                JArray jsonArrayP = JArray.Parse(contenidoDelArchivoP);

                List<PresupuestoEnt> presupuestosFiltrados = new List<PresupuestoEnt>();
                //DateTime fechaS = DateTime.ParseExact(FechaSalida, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                //DateTime fechaA = DateTime.ParseExact(FechaArribo, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                foreach (JObject presupuestoJson in jsonArrayP)
                {
                    string nrosegjson = (string)presupuestoJson["NroSeguimiento"];
                    //DateTime fechaSjson = DateTime.ParseExact((string)presupuestoJson["Productos"][0]["ProductoV"]["FechaSalida"], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    //DateTime fechaAjson = DateTime.ParseExact((string)presupuestoJson["Productos"][0]["ProductoV"]["FechaArribo"], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    if (nrosegjson == nroseguimiento)
                    {

                        //var productos = JsonConvert.DeserializeObject<List<ProductoLineaEnt>>(presupuestoJson["Productos"].ToString());


                        PresupuestoEnt presupuesto = new PresupuestoEnt
                        {
                            NroSeguimiento = Convert.ToInt32(presupuestoJson["NroSeguimiento"]),
                            Productos = JsonConvert.DeserializeObject<List<ProductoLineaEnt>>(presupuestoJson["Productos"].ToString()),
                            Descripcion = (string)presupuestoJson["Descripcion"],
                            Total = Convert.ToInt32(presupuestoJson["Total"])

                        };
                        Console.WriteLine(presupuesto.Productos);


                        presupuestosFiltrados.Add(presupuesto);

                    }

                }
                return presupuestosFiltrados;
            }
            else
            {
                Console.WriteLine("El archivo no existe");
                return new List<PresupuestoEnt>();
            }
        }
        public static List<ItinerarioEnt> ListaItinerarioPre(string nroseguimiento)
        {

            if (File.Exists("Itinerarios.json"))
            {
                Console.WriteLine("El archivo existe");
                string contenidoDelArchivo = File.ReadAllText("Itinerarios.json");

                JArray jsonArray = JArray.Parse(contenidoDelArchivo);

                List<ItinerarioEnt> itinerariosFiltrados = new List<ItinerarioEnt>();

                foreach (JObject itinerarioJson in jsonArray)
                {
                    string nrosegjson = (string)itinerarioJson["Presupuesto"]["NroSeguimiento"];
                    string estadojson = (string)itinerarioJson["Estado"];


                    if (nrosegjson == nroseguimiento && estadojson == "PreReserva")
                    {
                        var formatoFecha = new JsonSerializerSettings
                        {
                            DateFormatString = "dd/MM/yyyy", // Specify the custom date format
                        };

                        var presupuestos = JsonConvert.DeserializeObject<PresupuestoEnt>(itinerarioJson["Presupuesto"].ToString(), formatoFecha);
                        var cliente = JsonConvert.DeserializeObject<ClienteEnt>(itinerarioJson["Cliente"].ToString());

                        ItinerarioEnt itinerario = new ItinerarioEnt
                        {
                            Presupuesto = presupuestos, //JsonConvert.DeserializeObject<PresupuestoEnt>(itinerarioJson["Presupuesto"].ToString()),
                            Cliente = cliente //JsonConvert.DeserializeObject<ClienteEnt>(itinerarioJson["Cliente"].ToString()),                          


                        };
                        Console.WriteLine(itinerario.Presupuesto);
                        Console.WriteLine(itinerario.Cliente);


                        itinerariosFiltrados.Add(itinerario);

                    }

                }
                return itinerariosFiltrados;
            }
            else
            {
                Console.WriteLine("El archivo no existe");
                return new List<ItinerarioEnt>();
            }
        }
        public static List<ItinerarioEnt> ListaItinerarioReserva(string nroseguimiento)
        {

            if (File.Exists("Itinerarios.json"))
            {
                Console.WriteLine("El archivo existe");
                string contenidoDelArchivo = File.ReadAllText("Itinerarios.json");

                JArray jsonArray = JArray.Parse(contenidoDelArchivo);

                List<ItinerarioEnt> itinerariosFiltrados = new List<ItinerarioEnt>();

                foreach (JObject itinerarioJson in jsonArray)
                {
                    string nrosegjson = (string)itinerarioJson["Presupuesto"]["NroSeguimiento"];
                    string estadojson = (string)itinerarioJson["Estado"];


                    if (nrosegjson == nroseguimiento && estadojson == "Reserva")
                    {
                        var presupuestos = JsonConvert.DeserializeObject<PresupuestoEnt>(itinerarioJson["Presupuesto"].ToString());
                        var cliente = JsonConvert.DeserializeObject<ClienteEnt>(itinerarioJson["Cliente"].ToString());

                        ItinerarioEnt itinerario = new ItinerarioEnt
                        {
                            Presupuesto = presupuestos, //JsonConvert.DeserializeObject<PresupuestoEnt>(itinerarioJson["Presupuestos"].ToString()),
                            Cliente = cliente,//JsonConvert.DeserializeObject<List<ClienteEnt>>(itinerarioJson["Cliente"].ToString()),                          
                            EstadoPago = (string)itinerarioJson["EstadoPago"],

                        };
                        Console.WriteLine(itinerario.Presupuesto);
                        Console.WriteLine(itinerario.Cliente);


                        itinerariosFiltrados.Add(itinerario);

                    }

                }
                return itinerariosFiltrados;
            }
            else
            {
                Console.WriteLine("El archivo no existe");
                return new List<ItinerarioEnt>();
            }
        }

        public static ClienteEnt CrearCliente(string nombre, string apellido, string dni, string cuil, string condFiscal, string telefono, string email)
        {
            PersonaFisicaEnt persona = new PersonaFisicaEnt
            {
                Nombre = nombre + " " + apellido,
                DNI = dni,
                CUIL = cuil,
            };

            ClienteEnt cliente = new ClienteEnt
            {
                PersonaFisica = persona,
                PersonaJuridica = null,
                CondFiscal = condFiscal,
                Telefono = telefono,
                Email = email,
                MedioPago = null
            };

            return cliente;

        }

        public static ItinerarioEnt CrearPrereserva(PresupuestoEnt presupuesto, ClienteEnt cliente)
        {
            ItinerarioEnt prereserva = new ItinerarioEnt
            {
                Presupuesto = presupuesto,
                Cliente = cliente,
                Estado = "PreReserva",
                EstadoPago = "Pendiente"
            };
            return prereserva;
        }

        public static DialogResult GrabarPrereserva(ItinerarioEnt prereserva)
        {
            DialogResult result = MessageBox.Show("¿Desea grabar la pre-reserva?", "Grabar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (File.Exists("Itinerarios.json"))
                {
                    JArray jsonArray = ArchivoItinerario.LeerItinerario();

                    var itinerarioJson = JsonConvert.SerializeObject(prereserva, Formatting.Indented);

                    jsonArray.Add(JObject.Parse(itinerarioJson));

                    ArchivoItinerario.GrabarItinerario(jsonArray);

                    MessageBox.Show("La pre-reserva se grabó correctamente", "Grabar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    JArray jsonArray = new JArray();

                    var itinerarioJson = JsonConvert.SerializeObject(prereserva, Formatting.Indented);

                    jsonArray.Add(JObject.Parse(itinerarioJson));

                    File.WriteAllText("Itinerarios.json", jsonArray.ToString());

                    MessageBox.Show("La pre-reserva se grabó correctamente", "Grabar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return result;

        }
    }
}

