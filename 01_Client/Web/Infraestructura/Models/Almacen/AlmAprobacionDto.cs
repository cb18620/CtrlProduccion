using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Models.Almacen
{
    public partial class AlmAprobacionDto
    {
        public int idsolicitud { get; set; }
        public string codigoDespacho { get; set; }
        public int estado { get; set; }
    }
}
