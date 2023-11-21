using Aplicacion.DTOs.Almacen;
using Aplicacion.Interfaces;
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

    public class GetAllAlmContenidoPalletsControlQuery : IRequest<Response<List<AlmContenidoPalletsDto>>>
    {
        public int idCabecera { get; set; }
        public int NumPallet { get; set; }
        public class GetAllAlmContenidoPalletsControlQueryHandler : IRequestHandler<GetAllAlmContenidoPalletsControlQuery, Response<List<AlmContenidoPalletsDto>>>
        {
            private readonly IRepositoryAsync<AlmContenidoPallets> _repositoryAsync;
            private readonly IMapper _mapper;
            public GetAllAlmContenidoPalletsControlQueryHandler(IRepositoryAsync<AlmContenidoPallets> repositoryAsync, IMapper mapper)
            {
                _repositoryAsync = repositoryAsync;
                _mapper = mapper;
            }

            public async Task<Response<List<AlmContenidoPalletsDto>>> Handle(GetAllAlmContenidoPalletsControlQuery request,  CancellationToken cancellationToken)
            {
                var _AlmContenidoPallets = await _repositoryAsync.ListAsync(new ObjetoSpecification2(request.idCabecera, request.NumPallet));
                var _AlmContenidoPalletsDto = _mapper.Map<List<AlmContenidoPalletsDto>>(_AlmContenidoPallets);
                return new Response<List<AlmContenidoPalletsDto>>(_AlmContenidoPalletsDto);
            }

            
        }

    }

    public class ObjetoSpecification2 : Specification<AlmContenidoPallets>
    {
        public ObjetoSpecification2(int Parametro1, int Parametro2)
        {
            Query.Where(x => x.IdalmCabeceraPallets == Parametro1 && x.NumPallet== Parametro2);
        }
    }

   

 
}
