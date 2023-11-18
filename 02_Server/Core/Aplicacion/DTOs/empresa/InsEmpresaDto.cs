using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.DTOs.empresa
{
    public class InsEmpresaDto
    {

        public int IdinsEmpresa { get; set; }
        public string Nit { get; set; }
        public string NombreRepresentante { get; set; }
        public int IdcTipoempresa { get; set; }
        public string Ubicacion { get; set; }
        public string RazonSocial { get; set; }
    }
}
