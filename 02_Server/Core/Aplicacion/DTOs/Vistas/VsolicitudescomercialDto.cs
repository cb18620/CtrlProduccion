using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.DTOs.Vistas
{
    public class VsolicitudescomercialDto
    {
        public int IdalmSalidadespacho { get; set; }
        public string NumeroListaempaque { get; set; } 
        public DateTime? FechaDespacho { get; set; }
        public int Idsolicitud { get; set; }
        public string? Observacion { get; set; }
        public string? UsuarioCreacion { get; set; } 
        public DateTime? FechaCreacion { get; set; }
        public string? UsuarioModificacion { get; set; } 
        public DateTime? FechaModificacion { get; set; }
        public int Estado { get; set; }
        public string NombreTransportista { get; set; } 
        public string NumPlaca { get; set; } 
        public string Marca { get; set; } 
        public string Color { get; set; } 
        public string NumLicencia { get; set; }
        public string Largo { get; set; } 
        public string Ancho { get; set; } 
        public long TotalPallet { get; set; }
    }
}
