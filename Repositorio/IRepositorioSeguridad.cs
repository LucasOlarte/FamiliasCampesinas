using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public interface IRepositorioSeguridad
    {
        public Usuario ObtenerUsuario(string nombreUsuario);
    }

    public class Usuario
    {
        internal string? Clave;
        internal string? NombreUsuario;
    }
}
