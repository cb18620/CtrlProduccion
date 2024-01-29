using Dominio.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Dominio.Entities
{
    public partial class Vpalletalmacen
    {
        [Key]
        public int IdalmAlmacenpalletsdetalle { get; set; }
        public int? Conforme { get; set; }
        public string Nombre { get; set; }
        public int? Linea { get; set; }
        public string Lote { get; set; }
        public string Op { get; set; }

    }
}
