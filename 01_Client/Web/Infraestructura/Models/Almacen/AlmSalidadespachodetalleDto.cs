using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Models.Almacen
{
    public partial class AlmSalidadespachodetalleDto
    {
        public int IdalmSalidadespachodetalle { get; set; }
        public int? NumeroPallet { get; set; }

        public int? IdalmSalidadespacho { get; set; }
        public int? CantidadBotellasSalida { get; set; }
        public bool VerDetalle {  get; set; }   
    }
}
