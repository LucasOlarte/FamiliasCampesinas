using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioMaestroADO : IRepositorioMaestro
    {
        public List<Municipio> ObtenerMunicipio()
        {
            var ObtenerMunicipio = new List<Municipio>();

            using (var conexion = new SqlConnection(ConfigurationManager.
                ConnectionStrings["Familias_campesinas"].ConnectionString))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id, Nombre FROM Municipio ORDER BY Nombre";
                comando.Connection = conexion;

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ObtenerMunicipio.Add(new Municipio()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = Convert.ToString(reader["Nombre"])
                        });
                    }
                }

            }

            return ObtenerMunicipio;
        }
    }

    public class Municipio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
