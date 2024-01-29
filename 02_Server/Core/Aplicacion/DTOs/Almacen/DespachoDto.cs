using Dominio.Entities.empresa;
using Dominio.Entities.Transporte;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.DTOs.Almacen
{
    public partial class DespachoDto
    {
        //public int IdalmSalidadespacho { get; set; }
        //public DateTime? Fecha { get; set; }
        //public string NumeroListaempaque { get; set; }
        //public int IdinsEmpresa { get; set; }
        //public InsEmpresa InsEmpresas { get; set; }
        //public int IdinsTransporte { get; set; }
        //public InsTransporte InsTransportes { get; set; }
        //public int Idsolicitud { get; set; }
        //public string Observacion { get; set; }
        // Fecha, NumeroListaempaque, y Observacion probablemente son campos comunes en todas las operaciones
        public int IdalmSalidadespacho { get; set; }
        public DateTime? Fecha { get; set; }
        public string NumeroListaempaque { get; set; }
        public string Observacion { get; set; }

        // Campos para la relación con InsEmpresa e InsTransporte. Pueden ser necesarios en CREATE y UPDATE
        public int? IdinsEmpresa { get; set; } // Usar nullable para permitir flexibilidad
        public InsEmpresa InsEmpresas { get; set; }
        public int? IdinsTransporte { get; set; } // Igual aquí, usar nullable
        public InsTransporte InsTransportes { get; set; }
        // Campos adicionales de InsEmpresa e InsTransporte, útiles si necesitas crear o actualizar estas entidades relacionadas
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
    }
}
