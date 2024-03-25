using Dominio.Common;
using Dominio.Entities.empresa;
using Dominio.Entities.Transporte;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace Dominio.Entities.Almacen
{
    [Table("alm_salidadespacho", Schema = "public")]
    public partial class AlmSalidadespacho : AuditableBaseEntity
    {
        [Key]
        public int IdalmSalidadespacho { get; set; }
        public DateTime? Fecha { get; set; }
        public string NumeroListaempaque { get; set; }
        public int IdinsEmpresa { get; set; }
        [ForeignKey("IdinsEmpresa")] 
        public InsEmpresa InsEmpresas { get; set; }
        public int IdinsTransporte { get; set; }
        [ForeignKey("IdinsTransporte")]
        public InsTransporte InsTransportes { get; set; }
        public int Idsolicitud { get; set; }
        public string Observacion { get; set; }
        public int Estado { get; set; }
    }
}
