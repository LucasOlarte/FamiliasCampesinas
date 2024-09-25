using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;

namespace Negocio
{
    public class ServicioEvaluacion : IServicioEvaluacion
    {
        private IRepositorioEvaluacion repositorio;

        public ServicioEvaluacion(RepositorioEvaluacion repositorio)
        {
            this.repositorio = (IRepositorioEvaluacion)repositorio;
        }

        public ServicioEvaluacion()
        {
            repositorio = new RepositorioEvaluacionEF();
        }

        public void GuardarEvaluacion(Evaluacion evaluacion)
        {
            repositorio.GuadarEvaluacion(evaluacion);
        }
    }

    public class Evaluacion
    {
    }

    internal class RepositorioEvaluacionEF : IRepositorioEvaluacion
    {
        public void GuadarEvaluacion(Evaluacion evaluacion)
        {
            throw new NotImplementedException();
        }
    }

    public class RepositorioEvaluacion
    {
    }

    internal interface IRepositorioEvaluacion
    {
        void GuadarEvaluacion(Evaluacion evaluacion);
    }

    public interface IServicioEvaluacion
    {
    }
}