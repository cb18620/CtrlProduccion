using Dominio.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace Dominio.Entities
{
    public partial class ValmCabecerapallets
    {
        [Key]
        public int IdAlmCabeceraPallets { get; set; }
        public int Molde { get; set; }
        public string OrdenProduccion { get; set; }
        public int Color { get; set; }
        public int EnProceso { get; set; }
        public int Reproceso { get; set; }
        public int NoConforme { get; set; }
        public int Conforme { get; set; }
        public string Descripcioncolor { get; set; }
        public string Descripcionmolde { get; set; }
        public string Descripcionlinea { get; set; }

    }
}
