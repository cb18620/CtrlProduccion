using Dominio.Entities;
using Aplicacion.Almacen.DTOs;
using Aplicacion.DTOs;
using Aplicacion.DTOs.Almacen;
using Aplicacion.DTOs.empresa;
using Aplicacion.DTOs.Parametricas;
using Aplicacion.DTOs.Segurity;
using Aplicacion.DTOs.Transporte;
using Aplicacion.Features.Aplicacion.Parametricas.Commands;
using AutoMapper;
using Dominio.Entities.Almacen;
using Dominio.Entities.empresa;

using Dominio.Entities.Seguridad;
using Dominio.Entities.Seguridadmetricas;
using Dominio.Entities.Transporte;
using Dominio.Entities.Vistas;

namespace Aplicacion.Mappings
{
    public class GeneralMappings : Profile
    {
        public GeneralMappings()
        {
            //TODO: Agregar aqui el registro de mapeo para obtenion de consultas  direccion  EntidadDominio --> ModeloDto
            #region QueryDto
            CreateMap<SegvUsuario, SegUsuarioDto>();
            CreateMap<GenPersona, PersonaDto>();
            CreateMap<GenClasificador, GenClasificadorDto>();
            CreateMap<GenClasificadortipo, GenClasificadortipoDto>();
            CreateMap<InsEmpresa, InsEmpresaDto>();
            CreateMap<InsTransporte, TransporteDto>();
            CreateMap<AlmCabeceraPallets, AlmCabeceraPalletsDto>();
            CreateMap<AlmContenidoPallets, AlmContenidoPalletsDto>();
            CreateMap<AlmSalidadespacho, AlmSalidadespachoDto>();
            CreateMap<AlmSalidadespachodetalle, AlmSalidadespachodetalleDto>();
            CreateMap<Vpalletalmacen, VpalletalmacenDto>();
            CreateMap<Vpalletalmacend, VpalletalmacendDto>();
            CreateMap<AlmSalidadespacho, DespachoDto>();
            /**///**

            #endregion

            //TODO: Agregar aqui el registro de mapeo para ejecucion de comandos  direccion  ModeloDto --> EntidadDominio Ej. : CreateMap<ProductoDto, CapProducto>();
            #region Commands
            CreateMap<PersonaDto, GenPersona>();
            CreateMap<CreatePersonaCommand, GenPersona>();
            CreateMap<GenClasificadortipoDto, GenClasificadortipo>();
            CreateMap<GenClasificadorDto, GenClasificador>();
            CreateMap<InsEmpresaDto, InsEmpresa>();
            CreateMap<TransporteDto, InsTransporte>();
            CreateMap<AlmCabeceraPalletsDto, AlmCabeceraPallets>();
            CreateMap<AlmContenidoPalletsDto, AlmContenidoPallets>();
            CreateMap<ValmCabecerapallets, ValmCabecerapalletsDto>();
            CreateMap<AlmSalidadespachoDto, AlmSalidadespacho>();
            CreateMap<AlmSalidadespachodetalleDto, AlmSalidadespachodetalle>();
            CreateMap<VpalletalmacenDto, Vpalletalmacen>();
            CreateMap<VpalletalmacendDto, Vpalletalmacend>();
            CreateMap<DespachoDto, AlmSalidadespacho>();


            #endregion 
        }
    }
}
