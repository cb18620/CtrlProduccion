using Dominio.Common;
using Dominio.Entities.Seguridad;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entities.Almacen
{
    [Table("alm_contenido_pallets", Schema = "public")]
    public class AlmContenidoPallets : AuditableBaseEntity
    {
        [Key]
        public int IdAlmContenidoPallets { get; set; }
        public int Turno { get; set; }
        [ForeignKey("Turno")]
        public GenClasificador Turnos { get; set; }
        public int? Tipo { get; set; }
        [ForeignKey("Tipo")]
        public GenClasificador Tipos { get; set; }
        public System.DateTime? Fecha { get; set; }
        public int? NumPallet { get; set; }
        public int? EstadoPallet { get; set; }
        public int IdalmCabeceraPallets { get; set; }
        public int CantidadBotellas { get; set; }
        public string Observacion { get; set; }
        public string Analisis { get; set; }
        public int? Estadolectura { get; set; }
    }
}
