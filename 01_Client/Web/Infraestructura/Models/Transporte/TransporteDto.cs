using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Models.Transporte
{
    public class TransporteDto
    {
        public int IdinsTransporte { get; set; }
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public string NombreTransportista { get; set; }
        public string NroLicencia { get; set; }
        public string Categoria { get; set; }
        public string largo { get; set; }
        public string Ancho { get; set; }
        public int? IdinsEmpresa { get; set; }
        public bool VerDetalle { get; set; }    
    }
}
