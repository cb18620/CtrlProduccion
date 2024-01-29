using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.DTOs
{

    public  class VpalletalmacenDto
    {
      
        public int IdalmAlmacenpalletsdetalle { get; set; }
        public int? Conforme { get; set; }
        public string Nombre { get; set; }
        public int? Linea { get; set; }
        public string Lote { get; set; }
        public string Op { get; set; }
        public DateTime? FechaCreacion { get; set; }


    }
}
