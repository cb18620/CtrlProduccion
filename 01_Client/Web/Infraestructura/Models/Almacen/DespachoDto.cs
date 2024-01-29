using Dominio.Entities.empresa;
using Dominio.Entities.Transporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Models.Almacen
{
    public partial class DespachoDto
    {
        public int IdalmSalidadespacho { get; set; }
        public DateTime? Fecha { get; set; }
        public string NumeroListaempaque { get; set; }
        public string Observacion { get; set; }

        public int IdinsEmpresa { get; set; } 
        public InsEmpresa InsEmpresas { get; set; }
        public int IdinsTransporte { get; set; } 
        public InsTransporte InsTransportes { get; set; }

        public string Nit { get; set; }
        public string NombreRepresentante { get; set; }
        public string Ubicacion { get; set; }
        public string RazonSocial { get; set; }
        public string Descripcion { get; set; }

        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public string NombreTransportista { get; set; }
        public string NroLicencia { get; set; }
        public string Categoria { get; set; }
        public bool VerDetalle {  get; set; }   
    }
}
