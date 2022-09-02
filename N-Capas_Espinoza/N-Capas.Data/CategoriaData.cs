using N_Capas.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Capas.Data
{
    public class CategoriaData
    {
        string cadenaConexion = "server=localhost; database=Parcial; Integrated Security=true";
        public List<Categoria> Listar()
        {
            var listado = new List<Categoria>();
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (var comando = new SqlCommand("SELECT * FROM Categoria", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            Categoria categoria;
                            while (lector.Read())
                            {
                                categoria = new Categoria();
                                categoria.IdCategoria = int.Parse(lector[0].ToString());
                                categoria.Nombre = lector[2].ToString();
                                listado.Add(categoria);
                            }
                        }
                    }
                }
            }
            return listado;
        }
    }
}
