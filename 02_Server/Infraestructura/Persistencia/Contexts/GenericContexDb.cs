using Dominio.Entities;

using Dominio.Entities.Almacen;
using Dominio.Entities.empresa;
using Dominio.Entities.Seguridad;
using Dominio.Entities.Seguridadmetricas;
using Dominio.Entities.Transporte;
using Dominio.Entities.Vistas;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Contexts
{
    public class GenericContexDb : DbContext
    {
        public GenericContexDb(DbContextOptions options) : base(options)
        {

        }

        //TODO:  Agregar aqui DbSets de las entidades de dominio correspondiente al contexto de conexcion general.

        #region DbSets
        public DbSet<GenPersona> GenPersona { get; set; }
        public DbSet<GenClasificador> Clasificador { get; set; }
        public DbSet<GenClasificadortipo> GenClasificadorTipo { get; set; }
        public DbSet<InsEmpresa> Empresa { get; set; }
        public DbSet<InsTransporte> Transporte { get; set; }
        public DbSet<AlmCabeceraPallets> AlmCabeceraPallets { get; set; }   
        public DbSet<AlmContenidoPallets> AlmContenidoPallets { get; set; } 
        public DbSet<ValmCabecerapallets> ValmCabecerapallets { get; set; }
        public DbSet<AlmSalidadespacho> Salidadespacho { get; set; }
        public DbSet<AlmSalidadespachodetalle> Salidadespachodetalle { get; set; }
        public DbSet<Vpalletalmacend> Vpalletalmacend {  get; set; }    
        public DbSet<Vpalletalmacen> vpalletalmacen { get; set; }
        public DbSet<Vsolicitudescomercial> Vsolicitudescomercial { get; set; } 

        #endregion

    }
}
