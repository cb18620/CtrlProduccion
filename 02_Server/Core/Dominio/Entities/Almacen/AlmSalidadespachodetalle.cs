using Dominio.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace Dominio.Entities.Almacen
{
    [Table("alm_salidadespachodetalle", Schema = "public")]
    public partial class AlmSalidadespachodetalle : AuditableBaseEntity
    {
        [Key]
        public int IdalmSalidadespachodetalle { get; set; }
        public int? NumeroPallet { get; set; }
  
        public int? IdalmSalidadespacho { get; set; }
        public int? CantidadBotellasSalida { get; set; }
    }
}
