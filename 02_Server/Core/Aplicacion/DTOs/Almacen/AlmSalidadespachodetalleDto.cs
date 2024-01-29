using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Almacen.DTOs
{
    public partial class AlmSalidadespachodetalleDto 
    {
        
        public int IdalmSalidadespachodetalle { get; set; }
        public int? NumeroPallet { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? IdalmSalidadespacho { get; set; }
    }
}
