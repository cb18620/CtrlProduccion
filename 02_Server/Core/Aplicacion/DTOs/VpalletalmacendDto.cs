﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.DTOs
{

    public  class VpalletalmacendDto
    {

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
