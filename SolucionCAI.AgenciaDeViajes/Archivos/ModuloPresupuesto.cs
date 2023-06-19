using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using SolucionCAI.AgenciaDeViajes.Entidades;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using SolucionCAI.AgenciaDeViajes;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;

namespace SolucionCAI.AgenciaDeViajes.Archivos
{
    public class ModuloPresupuesto
    {
        public static VueloEnt GenerarVuelo(Guid uid, string clase, string tipoPasajero, decimal tarifa, int cantPasajeros, string codigo, string origen, string destino, DateTime fechaPartida, DateTime fechaArribo, TimeSpan tiempoVuelo, string aerolinea)

        {

            List<TarifaEnt> listaTarifas = new List<TarifaEnt>();

            //List<VueloEnt> listaVuelos = new List<VueloEnt>();



            TarifaEnt tarifaVuelo = new TarifaEnt

            {

                Clase = clase,

                TipoPasajero = tipoPasajero,

                Precio = tarifa,

                Disponibilidad = cantPasajeros,
                Pasajeros = null,

            };

            listaTarifas.Add(tarifaVuelo);



            VueloEnt vueloSeleccionado = new VueloEnt

            {
                Uid = uid,

                Codigo = codigo,

                Origen = origen,

                Destino = destino,

                FechaSalida = fechaPartida,

                FechaArribo = fechaArribo,

                TiempoVuelo = tiempoVuelo,

                Aerolinea = aerolinea,

                Tarifas = listaTarifas,

            };

            return vueloSeleccionado;

        }
        public static ProductoLineaEnt AgregarVueloLinea(VueloEnt vueloPresupuestado)
        {


            ProductoLineaEnt producto = new ProductoLineaEnt
            {
                ProductoV = vueloPresupuestado,
                ProductoH = null,
                PrecioUn = vueloPresupuestado.Tarifas[0].Precio,
                Cantidad = vueloPresupuestado.Tarifas[0].Disponibilidad,
            };


            return producto;
        }

        public static int BuscarUltimoId()
        {
            int id = 1000;
            JArray jsonPresupuestos = ArchivoPresupuesto.LeerPresupuesto();
            if (jsonPresupuestos == null)
            {
                return id;
            }
            else
            {
                JObject lastObject = (JObject)jsonPresupuestos.Last;
                id = (int)lastObject["NroSeguimiento"];
            }
            return id;

        }

        public static PresupuestoEnt TraerPresupuesto(int nroSeguimiento)
        {
            JArray jsonPresupuestos = ArchivoPresupuesto.LeerPresupuesto();

            foreach (JObject presupuesto in jsonPresupuestos)
            {
                if (Convert.ToInt32(presupuesto["NroSeguimiento"]) == nroSeguimiento)
                {
                    PresupuestoEnt presupuestoEncontrado = JsonConvert.DeserializeObject<PresupuestoEnt>(presupuesto.ToString());
                    //foreach (var fecha in presupuesto["Presupuesto"]["Productos"][0]["ProductoH"]["Disponibilidad"]["HabitacionFechaDisp"])
                    //{
                    //    DateTime fechaJsonParsed = DateTime.ParseExact(fecha["FechaEntHab"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    //    Guid uidJson = Guid.Parse(fecha["Uid"].ToString());
                    //    if (uidJson == presupuestoEncontrado.Productos[0].ProductoH.Disponibilidad.HabitacionFechaDisp[0].Uid)
                    //    {
                    //        presupuestoEncontrado.Productos[0].ProductoH.Disponibilidad.HabitacionFechaDisp[0].FechaEntHab = fechaJsonParsed;
                    //    }
                    //}
                    
                    return presupuestoEncontrado;
                }
            }
            return null;

        }

        public static PresupuestoEnt CrearPresupuesto(List<ProductoLineaEnt> productosAgregados, decimal total)
        {
            //List<PresupuestoEnt> listaPresupuestos = new List<PresupuestoEnt>();

            PresupuestoEnt presupuesto = new PresupuestoEnt
            {
                NroSeguimiento = BuscarUltimoId() + 1,
                Productos = productosAgregados,
                Total = total,
            };

            //listaPresupuestos.Add(presupuesto);

            return presupuesto;
        }

        public static DialogResult GrabarPresupuesto(PresupuestoEnt presupuesto)
        {
            if (File.Exists("Presupuestos.json"))
            {
                Console.WriteLine("El archivo existe");
                //string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Presupuestos.json");
                string existingJsonString = File.ReadAllText("Presupuestos.json");

                if(string.IsNullOrEmpty(existingJsonString))
                {
                    List<PresupuestoEnt> dataExistente = new List<PresupuestoEnt>();
                    dataExistente.Add(presupuesto);
                    string jsonString = JsonConvert.SerializeObject(dataExistente, Formatting.Indented);
                    File.WriteAllText("Presupuestos.json", jsonString);
                }
                else
                {
                    List<PresupuestoEnt> dataExistente = JsonConvert.DeserializeObject<List<PresupuestoEnt>>(existingJsonString);
                    dataExistente.Add(presupuesto);
                    string jsonString = JsonConvert.SerializeObject(dataExistente, Formatting.Indented);
                    File.WriteAllText("Presupuestos.json", jsonString);
                    Console.WriteLine(jsonString);
                }

                return MessageBox.Show("Presupuesto generado con éxito", "Confirmation");
            }
            else
            {
                List<PresupuestoEnt> data = new List<PresupuestoEnt>();

                data.Add(presupuesto);
                string jsonString = JsonConvert.SerializeObject(data);
                File.WriteAllText("Presupuestos.json", jsonString);
                Console.WriteLine(jsonString);
                return MessageBox.Show("Presupuesto creado con éxito", "Confirmation");

            }
        }

        public static HotelEnt GenerarHotel(Guid uid, string codigo, string hotel, string ciudad, DateTime fechaEntrada, string direccion, int calificacion, string tipoHab, int capacidad, decimal tarifa, int adultos, int menores, int infantes)
        {
            //List<HotelEnt> listaHoteles = new List<HotelEnt>();
            DireccionEnt direccionEnt = new DireccionEnt();
            List<HabitacionFechaEnt> listaHabitaciones = new List<HabitacionFechaEnt>();

            HabitacionFechaEnt habitacionFecha = new HabitacionFechaEnt
            {
                FechaEntHab = fechaEntrada,
                CantHab = 1,
                //Uid = uidHabitacion,
            };
            listaHabitaciones.Add(habitacionFecha);

            string[] keysDireccion = direccion.Split(',');
            foreach (string key in keysDireccion)
            {
                string[] claveValor = key.Split(':');
                if(claveValor.Length > 1)
                {
                    string clave = claveValor[0].Trim();
                    string valor = claveValor[1].Trim();

                    PropertyInfo property = direccionEnt.GetType().GetProperty(clave);

                    if(property != null)
                    {
                        if (property.PropertyType == typeof(int))
                        {
                            int valorInt = int.Parse(valor);
                            property.SetValue(direccionEnt, valorInt, null);
                        }
                        else if (property.PropertyType == typeof(decimal))
                        {
                            decimal valorDecimal = decimal.Parse(valor);
                            property.SetValue(direccionEnt, valorDecimal, null);
                        }
                        else
                        {
                            property.SetValue(direccionEnt, valor, null);

                        }      
                    }
                }

                
            }

            DisponibilidadHabEnt disponibilidad = new DisponibilidadHabEnt
            {

                Nombre = hotel,
                TarifaHab = tarifa,
                Capacidad = capacidad,
                Adultos = adultos,
                Menores = menores,
                Infantes = infantes,
                HabitacionFechaDisp = listaHabitaciones
            };

            HotelEnt hotelSeleccionado = new HotelEnt
            {
                Uid = uid,
                Codigo = codigo,
                Nombre = hotel,
                CodigoCiudad = ciudad,
                Calificacion = calificacion,
                Direccion = direccionEnt,
                Disponibilidad = disponibilidad
            };

            return hotelSeleccionado;

        }

        public static ProductoLineaEnt AgregarHotelLinea(HotelEnt hotelPresupuestado)
        {

            //List<ProductoLineaEnt> listaProductos = new List<ProductoLineaEnt>();

            ProductoLineaEnt producto = new ProductoLineaEnt
            {
                ProductoV = null,
                ProductoH = hotelPresupuestado,
                Cantidad = hotelPresupuestado.Disponibilidad.HabitacionFechaDisp[0].CantHab,
                PrecioUn = hotelPresupuestado.Disponibilidad.TarifaHab,
            };

            return producto;
        }


    }
}


