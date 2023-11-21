using Aplicacion.DTOs.Almacen;
using Aplicacion.Interfaces;
using Aplicacion.Interfaces.Repositories;
using Aplicacion.Wrappers;
using Ardalis.Specification;
using AutoMapper;
using Dominio.Entities.Almacen;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Aplicacion.Features.Almacen.Queries
{

    public class GetAllAlmContenidoPalletsQuery : IRequest<Response<List<AlmContenidoPalletsDto>>>
    {
        public int idCabecera { get; set; }

        public class GetAllAlmContenidoPalletsQueryHandler : IRequestHandler<GetAllAlmContenidoPalletsQuery, Response<List<AlmContenidoPalletsDto>>>
        {
            /* private readonly IRepositoryAsync<AlmContenidoPallets> _repositoryAsync;
             private readonly IMapper _mapper;*/
            private readonly IDetallePalletsRepository _repo;

            public GetAllAlmContenidoPalletsQueryHandler(IDetallePalletsRepository _rep)
            {
                _repo = _rep;
            }

            public async Task<Response<List<AlmContenidoPalletsDto>>> Handle(GetAllAlmContenidoPalletsQuery request, CancellationToken cancellationToken)
            {
                var _Result = new Response<List<AlmContenidoPalletsDto>>();
                try
                {
                    _Result = await _repo.GetDestallePallet(request.idCabecera);
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

    public class ObjetoSpecification : Specification<AlmContenidoPallets>
    {
        public ObjetoSpecification(int Parametro1)
        {
            Query.Where(x => x.IdalmCabeceraPallets == Parametro1 && x.Tipo == (int)Enums.ClasificadorTipo.ProductoConforme);
        }
    }
}
