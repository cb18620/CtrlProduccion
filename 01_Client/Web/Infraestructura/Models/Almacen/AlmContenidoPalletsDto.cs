using Dominio.Entities.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Models.Almacen
{
    public class AlmContenidoPalletsDto
    {
     
        public int NumPalletinicial { get; set; } 
        public int NumPalletFinal { get; set; }
        public int IdAlmContenidoPallets { get; set; }
        public int Turno { get; set; }
        public GenClasificador Turnos { get; set; }
        public int Tipo { get; set; }
        public GenClasificador Tipos { get; set; }
        public int CantidadBotellas { get; set; }
        public System.DateTime? Fecha { get; set; }
        public int NumPallet { get; set; }
        public int? EstadoPallet { get; set; }
        public int IdalmCabeceraPallets { get; set; }
        public bool VerDetalle { get; set; }
        public string? DescripcionTurno { get; set; }
        public string? DescripcionTipo { get; set; }
 
        public string? Observacion { get; set; }
        public string? Analisis { get; set; }
        public int? Estadolectura { get; set; }
    }
}
