using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Almacen.DTOs
{
    public partial class AlmSalidadespachoDto 
    {
        
        public int IdalmSalidadespacho { get; set; }
        public DateTime? Fecha { get; set; }
        public string NumeroListaempaque { get; set; }

        public int IdinsEmpresa { get; set; }
        public int IdinsTransporte { get; set; }


        public string Nit { get; set; }
        public string NombreRepresentante { get; set; }
        public string Ubicacion { get; set; }
        public string RazonSocial { get; set; }
        public string Descripcion { get; set; }

         public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public string NombreTransportista { get; set; }
        public string NroLicencia { get; set; }
        public string Categoria { get; set; }
        public int Estado { get; set; }




    }
}
