using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Models.Almacen
{

    public  class ValmCabecerapalletsDto
    {

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
        public bool VerDetalle { get; set; }


    }
}
