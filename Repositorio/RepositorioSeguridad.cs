using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioSeguridad : IRepositorioSeguridad
    {
        public Usuario ObtenerUsuario(string nombreUsuario)
        {
            return new Usuario() { Clave = "1234", NombreUsuario = nombreUsuario };
        }
    }
}