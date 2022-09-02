using N_Capas.Data;
using N_Capas.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Capas.Logic
{
    public static class CategoriaBL
    {
        public static List<Categoria> Listar()
        {
            var categoriaData = new CategoriaData();
            return categoriaData.Listar();
        }
    }
}
