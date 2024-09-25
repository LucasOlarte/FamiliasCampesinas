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
        public List<Ciudad> ObtenerCiudades()
        {
            throw new NotImplementedException();
        }

        public List<Municipio> ObtenerMunicipio()
        {
            var ObtenerMunicipio = new List<Municipio>();

            return ObtenerMunicipio;
        }
    }

    public class Municipio
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
    }
}
