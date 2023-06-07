using SolucionCAI.AgenciaDeViajes.Entidades;
using System.Globalization;
using System.IO;

namespace SolucionCAI.AgenciaDeViajes.Archivos
{
    public class ModuloPresupuesto
    {   
        public static List<ProductoLineaEnt> LineaProductoVuelos(VueloEnt vuelosPresupuestados)
        {
            List<ProductoLineaEnt> listaProductos = new List<ProductoLineaEnt>();
            ProductoLineaEnt producto = new ProductoLineaEnt
            {
                ProductoV = vuelosPresupuestados,
                ProductoH = null,
                PrecioUn = vuelosPresupuestados.Tarifas[0].Precio,
                Cantidad = vuelosPresupuestados.Tarifas[0].Disponibilidad,
            };
            listaProductos.Add(producto);
            return listaProductos;

        }

    }
}


