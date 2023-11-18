using Dominio.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities.empresa
{
    [Table("empresa", Schema = "public")]
    public partial class InsEmpresa : AuditableBaseEntity
    {
        [Key]
        public int IdinsEmpresa { get; set; }
        public string Nit { get; set; }
        public string NombreRepresentante { get; set; }
        public int IdcTipoempresa { get; set; }
        public string Ubicacion { get; set; }
        public string RazonSocial { get; set; }
    }
}
