using Dominio.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entities.Seguridad;

namespace Dominio.Entities.Almacen
{
    [Table("alm_cabecera_pallets", Schema = "public")]
    public class AlmCabeceraPallets : AuditableBaseEntity
    {

        [Key]
        public int IdAlmCabeceraPallets { get; set; }
        public int Molde { get; set; }
        [ForeignKey("Molde")]
        public GenClasificador Moldes { get; set; }
        public string OrdenProduccion { get; set; }
        public int Color { get; set; }
        [ForeignKey("Color")]
        public GenClasificador Colors { get; set; }
        public int Linea { get; set; }
        [ForeignKey("Linea")]
        public GenClasificador Lineas { get; set; }
    }
}
