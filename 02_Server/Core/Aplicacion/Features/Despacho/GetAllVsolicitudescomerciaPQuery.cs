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


    public class GetAllVsolicitudescomercialPQuery : IRequest<Response<List<VsolicitudescomercialDto>>>
    {
         
        public class GetAllVsolicitudescomercialPQueryHandler : IRequestHandler<GetAllVsolicitudescomercialPQuery, Response<List<VsolicitudescomercialDto>>>
        {
            private readonly IRepositoryAsync<Vsolicitudescomercial> _repositoryAsync;
            private readonly IMapper _mapper;
            public GetAllVsolicitudescomercialPQueryHandler(IRepositoryAsync<Vsolicitudescomercial> repositoryAsync, IMapper mapper)
            {
                _repositoryAsync = repositoryAsync;
                _mapper = mapper;
            }

            public async Task<Response<List<VsolicitudescomercialDto>>> Handle(GetAllVsolicitudescomercialPQuery request, CancellationToken cancellationToken)
            {
                var _Vsolicitudescomercial = await _repositoryAsync.ListAsync(new VsolicitudescomercialPSpecification());
                var _VsolicitudescomercialDto = _mapper.Map<List<VsolicitudescomercialDto>>(_Vsolicitudescomercial);
                return new Response<List<VsolicitudescomercialDto>>(_VsolicitudescomercialDto);
            }
        }

    }

    public class VsolicitudescomercialPSpecification : Specification<Vsolicitudescomercial>
    {
        public VsolicitudescomercialPSpecification()
        {
            Query.Where(x => x.Estado > 0 );
        }
    }
}
