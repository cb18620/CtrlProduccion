using Aplicacion.DTOs.Almacen;
using Aplicacion.Interfaces;
using Aplicacion.Interfaces.Repositories;
using Aplicacion.Wrappers;
using Ardalis.Specification;
using AutoMapper;
using Dominio.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Aplicacion.Features.Almacen.Queries
{

    public class GetAllAlmContenidoPalletsProcesoQuery : IRequest<Response<List<AlmContenidoPalletsDto>>>
    {
        public int idCabecera { get; set; }

        public class GetAllAlmContenidoPalletsProcesoQueryHandler : IRequestHandler<GetAllAlmContenidoPalletsProcesoQuery, Response<List<AlmContenidoPalletsDto>>>
        {
            /* private readonly IRepositoryAsync<AlmContenidoPallets> _repositoryAsync;
             private readonly IMapper _mapper;*/
            private readonly IDetallePalletsProcesoRepository _repo;

            public GetAllAlmContenidoPalletsProcesoQueryHandler(IDetallePalletsProcesoRepository _rep)
            {
                _repo = _rep;
            }

            public async Task<Response<List<AlmContenidoPalletsDto>>> Handle(GetAllAlmContenidoPalletsProcesoQuery request, CancellationToken cancellationToken)
            {
                var _Result = new Response<List<AlmContenidoPalletsDto>>();
                try
                {
                    _Result = await _repo.GetDestallePalletProceso(request.idCabecera);

                    _Result.Message = _Result.Data.Count > 0 ? String.Format(Resources.Generic.Resource.QuerySucces, _Result.Data.Count) : Resources.Generic.Resource.QueryBad;
                    _Result.Succeeded = _Result.Data.Count > 0;
                }
                catch (Exception e)
                {
                    _Result.Message = e.Message;
                    _Result.Succeeded = false;
                }

                return _Result;
            }


        }

    }

}
