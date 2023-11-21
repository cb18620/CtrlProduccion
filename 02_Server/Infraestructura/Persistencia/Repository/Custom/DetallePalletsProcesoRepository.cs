
using Aplicacion.Wrappers;
using Persistencia.Contexts;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aplicacion.Interfaces.Repositories;
using Aplicacion.DTOs.Almacen;

namespace Persistencia.Repository.Custom
{
    public class DetallePalletsProcesoRepository : IDetallePalletsProcesoRepository
    {

        private readonly AplicationDbContext _context;
        public DetallePalletsProcesoRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response<List<AlmContenidoPalletsDto>>> GetDestallePalletProceso(int idCabecera)
        {
            var _Result = new Response<List<AlmContenidoPalletsDto>>();
            try
            {
                var vQuery = await Task.FromResult((from b in _context.AlmContenidoPallets
                                                    join t in _context.Clasificador on b.Tipo equals t.IdgenClasificador
                                                    join tu in _context.Clasificador on b.Turno equals tu.IdgenClasificador
                                                    where b.IdalmCabeceraPallets==idCabecera  && b.Tipo!=15
                                                    select new AlmContenidoPalletsDto
                                                    {
                                                        IdAlmContenidoPallets = b.IdAlmContenidoPallets,
                                                        Turno = b.Turno,
                                                        Tipo = b.Tipo,
                                                        Fecha = b.Fecha,
                                                        NumPallet = b.NumPallet,
                                                        EstadoPallet = b.EstadoPallet,
                                                        IdalmCabeceraPallets = b.IdalmCabeceraPallets,
                                                        DescripcionTurno = tu.Descripcion,
                                                        DescripcionTipo = t.Descripcion,
                                                        CantidadBotellas = b.CantidadBotellas,
                                                    }).ToList());
                _Result.Succeeded = vQuery.Count > 0;
                _Result.Data = new List<AlmContenidoPalletsDto>();
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
