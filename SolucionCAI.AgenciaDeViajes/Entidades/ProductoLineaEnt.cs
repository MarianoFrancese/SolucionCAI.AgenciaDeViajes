using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SolucionCAI.AgenciaDeViajes.Entidades
{
    public class ProductoLineaEnt
    {
        public HotelEnt ProductoH { get; set; } //ver si se puede cambiar a obj
        public VueloEnt ProductoV { get; set; } //ver si se puede cambiar a obj
        public int Cantidad { get; set; }
        public decimal PrecioUn { get; set; }
        public List<PasajeroEnt> Pasajeros { get; set; }
        public Decimal SubTotal { get { return CalcularSubtotal(Cantidad, PrecioUn); } }
        public Decimal IVA { get { return CalcularIVA(SubTotal); } }
        public Decimal TotalProd { get { return CalcularTotal(SubTotal, IVA); } }


        public static string MostrarDescripcionHotel(HotelEnt hotel)
        {
            return $"Codigo: {hotel.Codigo} - Hotel {hotel.Nombre} en {hotel.CodigoCiudad}";
        }
        public static string MostrarDescripcionVuelo(VueloEnt vuelo)
        {
            return $"Codigo: {vuelo.Codigo} - Vuelo de {vuelo.Origen} a {vuelo.Destino} con {vuelo.Aerolinea} - Fecha de Salida: {vuelo.FechaSalida} - Fecha de Arribo: {vuelo.FechaArribo}";
        }

        public static string VueloToString(VueloEnt vuelo)
        {
            TarifaEnt tarifa = vuelo.Tarifas[0];
            string mensaje =  $"Codigo: {vuelo.Codigo}, Origen: {vuelo.Origen}, Destino: {vuelo.Destino}, FechaSalida: {vuelo.FechaSalida}, FechaArribo: {vuelo.FechaArribo}, TiempoVuelo: {vuelo.TiempoVuelo}, Aerolinea: {vuelo.Aerolinea} - Tarifas: Clase: {tarifa.Clase}, TipoPasajero: {tarifa.TipoPasajero}, Precio: {tarifa.Precio}, Disponibilidad: {tarifa.Disponibilidad}";
            return mensaje;
        }

        public static VueloEnt ConvertirAVuelo(string mensaje)
        {
            List<TarifaEnt> tarifas = new List<TarifaEnt>();
            TarifaEnt tarifa = new TarifaEnt();
            VueloEnt vuelo = new VueloEnt();
            string[] partes = mensaje.Split('-');
            string parteTarifas = partes[1];
            string parteVuelos = partes[0];
            string[] keyValuesTarifas = parteTarifas.Split(',');
            string[] keyValuesVuelos = parteVuelos.Split(',');

            foreach (string key in keyValuesTarifas)
            {
                string[] claveValor = key.Split(':');
                if (claveValor.Length > 1)
                {
                    string clave = claveValor[0].Trim();
                    string valor = claveValor[1].Trim();

                    PropertyInfo property = tarifa.GetType().GetProperty(clave);

                    if (property != null)
                    {
                        if (property.PropertyType == typeof(string))
                        {
                            property.SetValue(tarifa, valor, null);
                        }
                        else if (property.PropertyType == typeof(decimal))
                        {
                            decimal valorDecimal = decimal.Parse(valor);
                            property.SetValue(tarifa, valorDecimal, null);
                        }
                        else if (property.PropertyType == typeof(int))
                        {
                            int valorInt = int.Parse(valor);
                            property.SetValue(tarifa, valorInt, null);
                        }
                    }
                }
            }
            tarifas.Add(tarifa);

            foreach (string key in keyValuesVuelos)
            {
                string[] claveValor = key.Split(':');
                if (claveValor.Length > 1)
                {
                    string clave = claveValor[0].Trim();
                    string valor = claveValor[1].Trim();
                    Console.WriteLine(valor);

                    PropertyInfo property = vuelo.GetType().GetProperty(clave);

                    if (property != null)
                    {
                        if (property.PropertyType == typeof(string))
                        {
                            property.SetValue(vuelo, valor, null);
                        }
                        else if (property.PropertyType == typeof(DateTime))
                        {
                            DateTime valorDatetime = DateTime.ParseExact(valor, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            property.SetValue(vuelo, valorDatetime, null);
                        }
                        else if (property.PropertyType == typeof(TimeSpan))
                        {
                            TimeSpan valorTime = TimeSpan.Parse(valor);
                            property.SetValue(vuelo, valorTime, null);
                        }
                    }
                }
            }
            vuelo.Tarifas = tarifas;
            return vuelo;
        }

        public decimal CalcularSubtotal(int cantidad, decimal precio)
        {
            decimal subtotal;

            subtotal = cantidad * precio;

            return subtotal;
        }

        public decimal CalcularIVA(decimal subtotal)
        {
            decimal iva;

            iva = subtotal * 0.21m;

            return iva;
        }

        public decimal CalcularTotal(decimal subtotal, decimal iva)
        {
            decimal total;

            total = subtotal + iva;

            return total;
        }

    }
}
