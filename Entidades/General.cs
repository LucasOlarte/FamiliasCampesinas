using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class General
    {
        public required string Usuario { get; set; }
        public required string Contraseña { get; set; }
        public required string Municipio {get; set; }
        public required string Subregion {get; set; }
        public required string Vereda {get; set; }
        public required string NombrePredio {get; set; }
        public required string TipoPredio {get; set; }
        public int DistanciaPredio {get; set; }
        public required string PredioCabeceraTransporte {get; set; }
        public int TiempoTransporte {get; set; }
        public required string ViaCabeceraPredio {get; set; }
    }
}
