using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productivo
    {
        public int LatitudPredio {get; set; }
        public int LongitudPredio {get; set; }
        public int AlturaPredio {get; set; }
        public int AreaPredio {get; set; }
        public required string PredioPropioArrendado {get; set; }
        public required string PoseeTituloDePredio {get; set; }
        public int CuantoPaga {get; set; }
        public required string ActividadPrincipal {get; set; }
        public required string MaterialCertificado {get; set; }
        public required string QueCultivosMaterialCertificado {get; set; }
        public required string AnalisisDeSuelo {get; set; }
        public required string BuenasPracticasAgricolas {get; set; }
        public required string QueCultivosBPA {get; set; }
        public required string ManejoYControlDePlagas {get; set; }
        public required string ConQueRealizaControlDePlagas {get; set; }
    }
}
