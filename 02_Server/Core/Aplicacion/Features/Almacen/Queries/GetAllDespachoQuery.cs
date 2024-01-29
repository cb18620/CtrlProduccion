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
    public class GetAllDespachoQuery : IRequest<Response<List<DespachoDto>>>
    {


        public class GetAllDespachoQueryHandler : IRequestHandler<GetAllDespachoQuery, Response<List<DespachoDto>>>
        {
            private readonly IRepositoryAsync<AlmSalidadespacho> _repositoryAsync;
            private readonly IMapper _mapper;
            public GetAllDespachoQueryHandler(IRepositoryAsync<AlmSalidadespacho> repositoryAsync, IMapper mapper)
            {
                _repositoryAsync = repositoryAsync;
                _mapper = mapper;
            }

            public async Task<Response<List<DespachoDto>>> Handle(GetAllDespachoQuery request, CancellationToken cancellationToken)
            {
                var _AlmCabeceraPallets = await _repositoryAsync.ListAsync(new AlmDespachoSpecification());
                var _AlmCabeceraPalletsDto = _mapper.Map<List<DespachoDto>>(_AlmCabeceraPallets);
                return new Response<List<DespachoDto>>(_AlmCabeceraPalletsDto);
            }

            
        }

    }

    public class AlmDespachoSpecification : Specification<AlmSalidadespacho>
    {
        public AlmDespachoSpecification()
        {
            Query.Include(x => x.InsEmpresas)
                .Include(y => y.InsTransportes);
             

        }
    }
}
