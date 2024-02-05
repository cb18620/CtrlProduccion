using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable enable

namespace Dominio.Entities.Vistas
{
    [Table("vsolicitudescomercial", Schema = "public")]
    public partial class Vsolicitudescomercial
    {
        [Key]
        [Column("idalm_salidadespacho")]
        public int IdalmSalidadespacho { get; set; }

        [Column("numero_listaempaque")]
        [StringLength(50)]
        public string NumeroListaempaque { get; set; } 

        [Column("fecha_despacho")]
        public DateTime? FechaDespacho { get; set; }

        [Column("idsolicitud")]
        public int Idsolicitud { get; set; }

        [Column("observacion")]
        public string? Observacion { get; set; }

        [Column("usuario_creacion")]
        [StringLength(40)]
        public string? UsuarioCreacion { get; set; } 

        [Column("fecha_creacion")]
        public DateTime? FechaCreacion { get; set; }

        [Column("usuario_modificacion")]
        [StringLength(40)]
        public string? UsuarioModificacion { get; set; } 

        [Column("fecha_modificacion")]
        public DateTime? FechaModificacion { get; set; }

        [Column("estado")]
        public int Estado { get; set; }

        [Column("nombre_transportista")]
        [StringLength(50)]
        public string? NombreTransportista { get; set; } 

        [Column("num_placa")]
        [StringLength(50)]
        public string NumPlaca { get; set; } 

        [Column("marca")]
        [StringLength(50)]
        public string Marca { get; set; } 

        [Column("color")]
        [StringLength(50)]
        public string Color { get; set; } 

        [Column("num_licencia")]
        [StringLength(50)]
        public string NumLicencia { get; set; } 

        [Column("largo")]
        [StringLength(109)]
        public string Largo { get; set; } 

        [Column("ancho")]
        [StringLength(100)]
        public string Ancho { get; set; } 

        [Column("total_pallet")]
        public long TotalPallet { get; set; }
    }
}
