using System;
using System.ComponentModel.DataAnnotations;
namespace Infraestructura.Models.Empresas
{
    public class EmpresaDto
    {
        public int IdinsEmpresa { get; set; }
        public string Nit { get; set; }
        public string NombreRepresentante { get; set; }
        public int IdcTipoempresa { get; set; }
        public string Ubicacion { get; set; }
        public string RazonSocial { get; set; }
        public bool VerDetalle { get; set; }
        public string Descripcion { get; set; }
    }
}
