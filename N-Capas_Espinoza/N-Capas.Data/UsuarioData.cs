using N_Capas.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Capas.Data
{
    public class UsuarioData
    {
        string cadenaConexion = "server=localhost; database=Parcial; Integrated Security=true";
        public List<Usuarios> Listar()
        {
            var listado = new List<Usuarios>();
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                using (var comando = new SqlCommand("SELECT * FROM Usuario", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            Usuarios usuarios;
                            while (lector.Read())
                            {
                                usuarios = new Usuarios();
                                usuarios.IdUsuario = int.Parse(lector[0].ToString());
                                usuarios.Nombres = lector[1].ToString();
                                usuarios.Apellidos = lector[2].ToString();
                                listado.Add(usuarios);
                            }
                        }
                    }
                }
            }
            return listado;
        }
    }
}
