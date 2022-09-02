using N_Capas.Data;
using N_Capas.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Capas.Logic
{
    public static class ProductoBL
    {
        public static List<Producto> Listar()
        {
            var productoData = new ProductoData();
            return productoData.Listar();
        }
        public static Producto BuscarPorId(int id)
        {
            var productoData = new ProductoData();
            return productoData.BuscarPorId(id);
        }
        public static bool Insertar(Producto producto)
        {
            var productoData = new ProductoData();
            return productoData.Insertar(producto);
        }
        public static bool Actualizar(Producto producto)
        {
            var productoData = new ProductoData();
            return productoData.Actualizar(producto);
        }
        public static bool Eliminar(int id)
        {
            var productoData = new ProductoData();
            return productoData.Eliminar(id);
        }
    }
}
