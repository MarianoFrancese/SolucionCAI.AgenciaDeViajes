using SolucionCAI.AgenciaDeViajes.Entidades;
using System.Globalization;
using System.IO;

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

                ProductoV = vuelosPresupuestados,

                ProductoH = null,

                PrecioUn = vuelosPresupuestados[0].Tarifas[0].Precio,

                Cantidad = vuelosPresupuestados[0].Tarifas[0].Disponibilidad,

            };

            listaProductos.Add(producto);

            return listaProductos;


        }

    }
}


