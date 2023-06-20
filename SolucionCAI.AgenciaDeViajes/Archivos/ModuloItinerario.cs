using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using SolucionCAI.AgenciaDeViajes.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SolucionCAI.AgenciaDeViajes.Archivos
{
    public class ModuloItinerario
    {
        public static List<PresupuestoEnt> ListaPresupuestos(string nroseguimiento)
        {

            if (File.Exists("Presupuestos.json"))
            {
                JArray jsonArrayP = ArchivoPresupuesto.LeerPresupuesto();

                List<PresupuestoEnt> presupuestosFiltrados = new List<PresupuestoEnt>();
                
                foreach (JObject presupuestoJson in jsonArrayP)
                {
                    string nrosegjson = (string)presupuestoJson["NroSeguimiento"];
                    
                    if (nrosegjson == nroseguimiento)
                    {

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
                JArray jsonArray = ArchivoItinerario.LeerItinerario();

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
                            Presupuesto = presupuestos,
                            Cliente = cliente,
                            EstadoPago = "Pendiente",
                            Estado = "PreReserva",

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
                JArray jsonArray = ArchivoItinerario.LeerItinerario();

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

        public static ClienteEnt CrearCliente(string nombre, string apellido, string dni, string cuil, string condFiscal, string telefono, string email, string medioPago)
        {
            PersonaFisicaEnt persona = new PersonaFisicaEnt
            {
                Nombre = nombre + " " + apellido,
                DNI = long.Parse(dni),
                CUIL = long.Parse(cuil),
            };

            ClienteEnt cliente = new ClienteEnt
            {
                PersonaFisica = persona,
                PersonaJuridica = null,
                CondFiscal = condFiscal,
                Telefono = Convert.ToInt32(telefono),
                Email = email,
                MedioPago = medioPago
            };

            return cliente;

        }

        public static ClienteEnt CrearClienteEmpresa (string razonSocial, string domicilio, string cuit, string condFiscal, string telefono, string email, string medioPago)
        {
            PersonaJuridicaEnt persona = new PersonaJuridicaEnt
            {
                RazonSocial = razonSocial,
                Domicilio = domicilio,
                CUIT = long.Parse(cuit),
            };

            ClienteEnt cliente = new ClienteEnt
            {
                PersonaFisica = null,
                PersonaJuridica = persona,
                CondFiscal = condFiscal,
                Telefono = int.Parse(telefono),
                Email = email,
                MedioPago = medioPago
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

                    ArchivoItinerario.GrabarItinerario(jsonArray);

                    MessageBox.Show("La pre-reserva se grabó correctamente", "Grabar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return result;

        }

        public static List<ItinerarioEnt> CargarPasajeros (ItinerarioEnt itinerario)
        {
            itinerario.Estado = "Reserva";
            if (File.Exists("Itinerarios.json"))
            {
                JArray jsonArray = ArchivoItinerario.LeerItinerario();
                var itinerariosJson = JsonConvert.DeserializeObject<List<ItinerarioEnt>>(jsonArray.ToString());
                for (int i = 0; i < itinerariosJson.Count; i++)
                {
                    if (itinerariosJson[i].Presupuesto.NroSeguimiento == itinerario.Presupuesto.NroSeguimiento)
                    {
                        itinerariosJson[i] = itinerario;
                        break;
                    }
                }

                return itinerariosJson;
            }
            else
            {
                List<ItinerarioEnt> itinerariosJson = new List<ItinerarioEnt>();
                itinerariosJson.Add(itinerario);

                return itinerariosJson;
            }
        }
        
        public static DialogResult GrabarReserva (List<ItinerarioEnt> itinerarios)
        {
            DialogResult result = MessageBox.Show("¿Desea grabar la reserva?", "Grabar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (File.Exists("Itinerarios.json"))
                {
                    JArray jsonReservas = new JArray();
                    var jsonArray = JsonConvert.SerializeObject(itinerarios, Formatting.Indented);
                    ArchivoItinerario.GrabarItinerarioString(jsonArray);

                }
                else
                {
                    JArray jsonArray = new JArray();

                    var itinerarioJson = JsonConvert.SerializeObject(itinerarios, Formatting.Indented);

                    jsonArray.Add(JObject.Parse(itinerarioJson));

                    ArchivoItinerario.GrabarItinerario(jsonArray);

                }
            }
            return result;

        }

        public static DialogResult GrabarReservaConfirmada(ItinerarioEnt reserva)
        {
            DialogResult result = MessageBox.Show("¿Desea generar la Reserva?", "Reservar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                reserva.Estado = "Reserva Confirmada";

                if (File.Exists("Itinerarios.json"))
                {
                    JArray jsonArray = ArchivoItinerario.LeerItinerario();


                    JObject reservaExistente = jsonArray.FirstOrDefault(item => item["Presupuesto"]["NroSeguimiento"].Value<int>() == reserva.Presupuesto.NroSeguimiento) as JObject;

                    if (reservaExistente != null)
                    {
                        jsonArray.Remove(reservaExistente);
                    }

                    var itinerarioJson = JsonConvert.SerializeObject(reserva, Formatting.Indented);



                    JObject reservaConfirmada = JObject.Parse(itinerarioJson);
                    jsonArray.Add(reservaConfirmada);

                    ArchivoItinerario.GrabarItinerario(jsonArray);

                    MessageBox.Show("La Reserva se grabó correctamente", "Reservar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    JArray jsonArray = new JArray();

                    var itinerarioJson = JsonConvert.SerializeObject(reserva, Formatting.Indented);


                    JObject reservaExistente = jsonArray.FirstOrDefault(item => item["Presupuesto"]["NroSeguimiento"].Value<int>() == reserva.Presupuesto.NroSeguimiento) as JObject;

                    if (reservaExistente != null)
                    {
                        jsonArray.Remove(reservaExistente); // Remove the existing reserva object
                    }
                    JObject reservaConfirmada = JObject.Parse(itinerarioJson);
                    jsonArray.Add(reservaConfirmada);

                    ArchivoItinerario.GrabarItinerario(jsonArray);

                    MessageBox.Show("La Reserva se grabó correctamente", "Reservar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return result;

        }
    }
}

