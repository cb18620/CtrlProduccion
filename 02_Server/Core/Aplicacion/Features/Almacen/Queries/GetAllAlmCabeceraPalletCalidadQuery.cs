using Aplicacion.DTOs;
using Aplicacion.Interfaces;
using Aplicacion.Wrappers;
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

    public class GetAllAlmCabeceraPalletQuery : IRequest<Response<List<ValmCabecerapalletsDto>>>
    {
       

        public class GetAllAlmCabeceraPalletQueryHandler : IRequestHandler<GetAllAlmCabeceraPalletQuery, Response<List<ValmCabecerapalletsDto>>>
        {
            private readonly IRepositoryAsync<ValmCabecerapallets> _repositoryAsync;
            private readonly IMapper _mapper;
            public GetAllAlmCabeceraPalletQueryHandler(IRepositoryAsync<ValmCabecerapallets> repositoryAsync, IMapper mapper)
            {
                _repositoryAsync = repositoryAsync;
                _mapper = mapper;
            }

            public async Task<Response<List<ValmCabecerapalletsDto>>> Handle(GetAllAlmCabeceraPalletQuery request,  CancellationToken cancellationToken)
            {
                var _AlmCabeceraPallets = await _repositoryAsync.ListAsync();
                var _AlmCabeceraPalletsDto = _mapper.Map<List<ValmCabecerapalletsDto>>(_AlmCabeceraPallets);
                return new Response<List<ValmCabecerapalletsDto>>(_AlmCabeceraPalletsDto);
            }

        }

    }

}
