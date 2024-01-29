
using Aplicacion.Wrappers;
using Persistencia.Contexts;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aplicacion.Interfaces.Repositories;
using Aplicacion.Almacen.DTOs;

namespace Persistencia.Repository.Custom
{
    public class SalidadespachoRepository : ISalidadespachoRepository
    {

        private readonly AplicationDbContext _context;
        public SalidadespachoRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response<List<AlmSalidadespachoDto>>> GetSalidadespacho()
        {
            var _Result = new Response<List<AlmSalidadespachoDto>>();
            try
            {
                var vQuery = await Task.FromResult((from r in _context.Salidadespacho
                                                    join p in _context.Empresa on r.IdinsEmpresa equals p.IdinsEmpresa
                                                    join t in _context.Transporte on r.IdinsTransporte equals t.IdinsTransporte

                                                    select new AlmSalidadespachoDto
                                                    {
                                                        IdalmSalidadespacho = r.IdalmSalidadespacho,
                                                        Fecha = r.Fecha,
                                                        NumeroListaempaque = r.NumeroListaempaque,
                                                        IdinsEmpresa = r.IdinsEmpresa,
                                                        IdinsTransporte = r.IdinsTransporte,
                                                        Nit = p.Nit,
                                                        NombreRepresentante = p.NombreRepresentante,
                                                        Ubicacion = p.Ubicacion,
                                                        RazonSocial = p.RazonSocial,
                                                        Matricula = t.Matricula,
                                                        Marca = t.Marca,
                                                        Color = t.Color,
                                                        NombreTransportista = t.NombreTransportista,
                                                        NroLicencia = t.NroLicencia,
                                                        Categoria = t.Categoria,
                                                      




                                                    }).ToList());
                _Result.Succeeded = vQuery.Count > 0;
                _Result.Data = new List<AlmSalidadespachoDto>();
                _Result.Data = vQuery;
            }
            catch (Exception e)
            {
                _Result.Succeeded = false;
                _Result.Message = e.Message;
            }

            return _Result;
        }

       
    }
}
