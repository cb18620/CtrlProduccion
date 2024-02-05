using Dominio.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Dominio.Entities.Vistas
{
    [Table("vpalletalmacend", Schema = "public")]
    public partial class Vpalletalmacend
    {
        [Key]
        public int IdAlmContenidoPallets { get; set; }
        public int IdAlmCabeceraPallets { get; set; }
        public int IdalmSalidadespacho { get; set; }
        public int IdalmSalidadespachodetalle { get; set; }
        public string Moldedescripcion { get; set; }
        public string Lineadescripcion { get; set; }
        public string Colordescripcion { get; set; }
        public string Tipodescripcion { get; set; }
        public int Molde { get; set; }
        public int Linea { get; set; }
        public int Color { get; set; }
        public int Tipo { get; set; }
        public int NumPallet { get; set; }
        public string OrdenProduccion { get; set; }
        public DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public int? CantidadBotellas { get; set; }
    }
}
