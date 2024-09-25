using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;

namespace Negocio
{
    public class ServicioMaestro : IServicioMaestro
    {
        private IRepositorioMaestro repositorio;

        public ServicioMaestro(RepositorioMaestro repositorio)
        {
            this.repositorio = (IRepositorioMaestro)repositorio;
        }

        public ServicioMaestro()
        {
            repositorio = new RepositorioMaestroEF();
        }

        public List<Ciudad> ObtenerCiudades()
        => repositorio.ObtenerCiudades();

    }

    internal class RepositorioMaestroEF : IRepositorioMaestro
    {
        public List<Ciudad> ObtenerCiudades()
        {
            throw new NotImplementedException();
        }
    }

    public class RepositorioMaestro
    {
    }

    internal interface IRepositorioMaestro
    {
        List<Ciudad> ObtenerCiudades();
    }
}