using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;

namespace Negocio
{
    public class ServicioSeguridad : IServicioSeguridad
    {
        private IRepositorioSeguridad repositorio;

        public ServicioSeguridad(RepositorioSeguridad repositorio)
        {
            this.repositorio = repositorio;
        }

        public ServicioSeguridad()
        {
            repositorio = new RepositorioSeguridadEF();
        }

        public bool ValidarUsuario(Usuario usuario)
        {
            var usuarioActual = repositorio.ObtenerUsuario(usuario.NombreUsuario);
            if (usuarioActual != null)
            {
            }

            return false;
        }
    }

    internal class RepositorioSeguridadEF : IRepositorioSeguridad
    {
        public object ObtenerUsuario(string? nombreUsuario)
        {
            throw new NotImplementedException();
        }
    }
}