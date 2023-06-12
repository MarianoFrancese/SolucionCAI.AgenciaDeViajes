using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using SolucionCAI.AgenciaDeViajes.Entidades;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using SolucionCAI.AgenciaDeViajes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SolucionCAI.AgenciaDeViajes.Archivos
{
    public class ModuloPresupuesto
    {
        public static List<VueloEnt> GenerarListaVuelo(string clase, string tipoPasajero, decimal tarifa, int cantPasajeros, string codigo, string origen, string destino, DateTime fechaPartida, DateTime fechaArribo, TimeSpan tiempoVuelo, string aerolinea)

        {

            List<TarifaEnt> listaTarifas = new List<TarifaEnt>();

            List<VueloEnt> listaVuelos = new List<VueloEnt>();



            TarifaEnt tarifaVuelo = new TarifaEnt

            {

                Clase = clase,

                TipoPasajero = tipoPasajero,

                Precio = tarifa,

                Disponibilidad = cantPasajeros,

            };

            listaTarifas.Add(tarifaVuelo);



            VueloEnt vueloSeleccionado = new VueloEnt

            {

                Codigo = codigo,

                Origen = origen,

                Destino = destino,

                FechaSalida = fechaPartida,

                FechaArribo = fechaArribo,

                TiempoVuelo = tiempoVuelo,

                Aerolinea = aerolinea,

                Tarifas = listaTarifas,

            };

            listaVuelos.Add(vueloSeleccionado);
            return listaVuelos;

        }
        public static List<ProductoLineaEnt> AgregarVueloLinea(List<VueloEnt> vuelosPresupuestados)
        {

            List<ProductoLineaEnt> listaProductos = new List<ProductoLineaEnt>();

            ProductoLineaEnt producto = new ProductoLineaEnt
            {
                ProductoV = vuelosPresupuestados[0].Descripcion,
                ProductoH = null,
                PrecioUn = vuelosPresupuestados[0].Tarifas[0].Precio,
                Cantidad = vuelosPresupuestados[0].Tarifas[0].Disponibilidad,

            };

            listaProductos.Add(producto);

            return listaProductos;
        }

        public static int BuscarUltimoId()
        {
            int id = 0;
            if (File.Exists("Presupuestos.json"))
            {
                Console.WriteLine("El archivo existe");
                string contenidoDelArchivo = File.ReadAllText("Presupuestos.json");
                JArray jsonArray = JArray.Parse(contenidoDelArchivo);
                JObject lastObject = (JObject)jsonArray.Last;

                id = (int)lastObject["NroSeguimiento"];

                return id;
            }
            else
            {
                return id;
            }
        }

        public static List<PresupuestoEnt> CrearPresupuesto(List<ProductoLineaEnt> productosAgregados, decimal total)
        {
            List<PresupuestoEnt> listaPresupuestos = new List<PresupuestoEnt>();

            PresupuestoEnt presupuesto = new PresupuestoEnt
            {
                NroSeguimiento = BuscarUltimoId() + 1,
                Productos = productosAgregados,
                Total = total,
            };

            listaPresupuestos.Add(presupuesto);

            return listaPresupuestos;
        }

        public static DialogResult GrabarPresupuesto(List<PresupuestoEnt> listaPresupuesto)
        {
            if (File.Exists("Presupuestos.json"))
            {
                Console.WriteLine("El archivo existe");
                //string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Presupuestos.json");
                string existingJsonString = File.ReadAllText("Presupuestos.json");

                List<PresupuestoEnt> dataExistente = JsonConvert.DeserializeObject<List<PresupuestoEnt>>(existingJsonString);

                PresupuestoEnt presupuesto = new PresupuestoEnt
                {
                    NroSeguimiento = listaPresupuesto[0].NroSeguimiento,
                    Productos = listaPresupuesto[0].Productos,
                    Total = listaPresupuesto[0].Total,
                };

                dataExistente.Add(presupuesto);
                string jsonString = JsonConvert.SerializeObject(dataExistente, Formatting.Indented);
                File.WriteAllText("Presupuestos.json", jsonString);
                Console.WriteLine(jsonString);

                return MessageBox.Show("Presupuesto generado con éxito", "Confirmation");
            }
            else
            {
                List<PresupuestoEnt> data = new List<PresupuestoEnt>();

                PresupuestoEnt presupuesto = new PresupuestoEnt
                {
                    NroSeguimiento = listaPresupuesto[0].NroSeguimiento,
                    Productos = listaPresupuesto[0].Productos,
                    Total = listaPresupuesto[0].Total,
                };

                data.Add(presupuesto);
                string jsonString = JsonConvert.SerializeObject(data);
                File.WriteAllText("Presupuestos.json", jsonString);
                Console.WriteLine(jsonString);
                return MessageBox.Show("Presupuesto creado con éxito", "Confirmation");

            }
        }

        public static List<HotelEnt> GenerarListaHotel(string codigo, string hotel, string ciudad, DateTime fechaEntrada, DateTime fechaSalida, string direccion, int calificacion, string tipoHab, int capacidad, decimal tarifa, int adultos, int menores, int infantes)
        {
            List<HotelEnt> listaHoteles = new List<HotelEnt>();
            DireccionEnt direccionEnt = new DireccionEnt();
            List<DisponibilidadHabEnt> listaDisponibilidades = new List<DisponibilidadHabEnt>();

            HabitacionFechaEnt habitacionFecha = new HabitacionFechaEnt
            {
                FechaEntHab = fechaEntrada,
                FechaSalHab = fechaSalida,
                CantHab = 1,
            };

            string[] keysDireccion = direccion.Split(',');
            foreach (string key in keysDireccion)
            {
                string[] claveValor = key.Split(':');
                string clave = claveValor[0].Trim();
                string valor = claveValor[1].Trim();
                direccionEnt.GetType().GetProperty(clave).SetValue(direccionEnt, valor);
            }

            DisponibilidadHabEnt disponibilidades = new DisponibilidadHabEnt
            {

                Nombre = hotel,
                TarifaHab = tarifa,
                Capacidad = capacidad,
                Adultos = adultos,
                Menores = menores,
                Infantes = infantes
            };
            listaDisponibilidades.Add(disponibilidades);

            HotelEnt hotelSeleccionado = new HotelEnt
            {
                Codigo = codigo,
                Nombre = hotel,
                CodigoCiudad = ciudad,
                Calificacion = calificacion,
                Direccion = direccionEnt,
                Disponibilidad = listaDisponibilidades,
                HabitacionFecha = habitacionFecha,
            };


            listaHoteles.Add(hotelSeleccionado);
            return listaHoteles;

        }

        public static List<ProductoLineaEnt> AgregarHotelLinea(List<HotelEnt> hotelesPresupuestados)
        {

            List<ProductoLineaEnt> listaProductos = new List<ProductoLineaEnt>();

            ProductoLineaEnt producto = new ProductoLineaEnt
            {
                ProductoV = null,
                ProductoH = hotelesPresupuestados[0].Descripcion,
                PrecioUn = hotelesPresupuestados[0].Disponibilidad[0].TarifaHab,
                Cantidad = hotelesPresupuestados[0].Disponibilidad[0].Capacidad,

            };

            listaProductos.Add(producto);
            return listaProductos;
        }


    }
}


