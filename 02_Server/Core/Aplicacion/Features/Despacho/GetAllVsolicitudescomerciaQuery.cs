using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Aplicacion.DTOs;
using Aplicacion.DTOs.Vistas;
using Aplicacion.Interfaces;
using Aplicacion.Wrappers;
using Ardalis.Specification;
using AutoMapper;
using Dominio.Entities.Vistas;
using MediatR;

namespace Aplicacion.Features.Despacho
{


    public class GetAllVsolicitudescomercialQuery : IRequest<Response<List<VsolicitudescomercialDto>>>
    {

        public class GetAllVsolicitudescomercialQueryHandler : IRequestHandler<GetAllVsolicitudescomercialQuery, Response<List<VsolicitudescomercialDto>>>
        {
            private readonly IRepositoryAsync<Vsolicitudescomercial> _repositoryAsync;
            private readonly IMapper _mapper;
            public GetAllVsolicitudescomercialQueryHandler(IRepositoryAsync<Vsolicitudescomercial> repositoryAsync, IMapper mapper)
            {
                _repositoryAsync = repositoryAsync;
                _mapper = mapper;
            }

            public async Task<Response<List<VsolicitudescomercialDto>>> Handle(GetAllVsolicitudescomercialQuery request, CancellationToken cancellationToken)
            {
                var _Vsolicitudescomercial = await _repositoryAsync.ListAsync(new VsolicitudescomercialSpecification());
                var _VsolicitudescomercialDto = _mapper.Map<List<VsolicitudescomercialDto>>(_Vsolicitudescomercial);
                return new Response<List<VsolicitudescomercialDto>>(_VsolicitudescomercialDto);
            }
        }

    }

    public class VsolicitudescomercialSpecification : Specification<Vsolicitudescomercial>
    {
        public VsolicitudescomercialSpecification()
        {
            Query.Where(x => x.Estado == 0 );
        }
    }
}
