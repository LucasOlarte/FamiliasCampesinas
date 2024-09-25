using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Social
    {
        public required string NombreResponsable {get; set; }
        public int DocumentoResponsable {get; set; }
        public int ContactoResponsable {get; set; }
        public required string CorreoResponsable {get; set; }
        public required string CampesinoSiNo {get; set; }
        public required string DesplazadoSiNo {get; set; }
        public int TiempoDesplazado {get; set; }
        public required string RetornadoPredio {get; set; }
        public int TiempoRetornado {get; set; }
        public required string NativoMunicipio {get; set; }
        public required string Proveniencia {get; set; }
        public required string Subsidio {get; set; }
        public required string CualSubsidio {get; set; }
        public required string PerteneceOrganizacion {get; set; }
        public required string RazonNoOrganizacion {get; set; }
        public int TiempoOrganizacion {get; set; }
        public required string NucleoFamiliarCampesino {get; set; }
        public required string NacieronEnLaVereda {get; set; }
        public int CuantosNacieronEnLaVereda {get; set; }
    }
}
