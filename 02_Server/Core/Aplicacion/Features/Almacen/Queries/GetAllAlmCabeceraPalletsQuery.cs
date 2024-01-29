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
    public class GetAllAlmCabeceraPalletsQuery : IRequest<Response<List<AlmCabeceraPalletsDto>>>
    {


        public class GetAllAlmCabeceraPalletsQueryHandler : IRequestHandler<GetAllAlmCabeceraPalletsQuery, Response<List<AlmCabeceraPalletsDto>>>
        {
            private readonly IRepositoryAsync<AlmCabeceraPallets> _repositoryAsync;
            private readonly IMapper _mapper;
            public GetAllAlmCabeceraPalletsQueryHandler(IRepositoryAsync<AlmCabeceraPallets> repositoryAsync, IMapper mapper)
            {
                _repositoryAsync = repositoryAsync;
                _mapper = mapper;
            }

            public async Task<Response<List<AlmCabeceraPalletsDto>>> Handle(GetAllAlmCabeceraPalletsQuery request, CancellationToken cancellationToken)
            {
                var _AlmCabeceraPallets = await _repositoryAsync.ListAsync(new AlmCabeceraPalletSpecification());
                var _AlmCabeceraPalletsDto = _mapper.Map<List<AlmCabeceraPalletsDto>>(_AlmCabeceraPallets);
                return new Response<List<AlmCabeceraPalletsDto>>(_AlmCabeceraPalletsDto);
            }

        }

    }

    public class AlmCabeceraPalletSpecification : Specification<AlmCabeceraPallets>
    {
        public AlmCabeceraPalletSpecification()
        {
            Query.Include(x => x.Moldes)
                .Include(y => y.Colors)
                .Include(z => z.Lineas);

        }
    }
}
