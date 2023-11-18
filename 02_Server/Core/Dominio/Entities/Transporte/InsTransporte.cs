using Dominio.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities.Transporte
{
    [Table("transporte", Schema = "public")]
    public partial class InsTransporte : AuditableBaseEntity
    {
        [Key]
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
    }
}
