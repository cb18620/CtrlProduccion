using Dominio.Entities.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Models.Almacen
{
    public class AlmCabeceraPalletsDto
    {
        public int IdAlmCabeceraPallets { get; set; }
        public int Molde { get; set; }
        public GenClasificador Moldes { get; set; }
        public string OrdenProduccion { get; set; }
        public int Color { get; set; }
        public GenClasificador Colors { get; set; }
        public int Linea { get; set; }
        public GenClasificador Lineas { get; set; }
        public bool VerDetalle { get; set; }

    }
}
