using Aplicacion.DTOs;
using Aplicacion.DTOs.Transporte;
using Aplicacion.Interfaces;
using Aplicacion.Wrappers;
using AutoMapper;
using Dominio.Entities;
using Dominio.Entities.Transporte;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Features.Transporte.Queries
{

    public class GetAllTransporteQuery : IRequest<Response<List<TransporteDto>>>
    {
       /* public TipoParametro1 Parametro1 { get; set; }
        public TipoParametro2 Parametro2 { get; set; }
        */

        public class GetAllTransporteQueryHandler : IRequestHandler<GetAllTransporteQuery, Response<List<TransporteDto>>>
        {
            private readonly IRepositoryAsync<InsTransporte> _repositoryAsync;
            private readonly IMapper _mapper;
            public GetAllTransporteQueryHandler(IRepositoryAsync<InsTransporte> repositoryAsync, IMapper mapper)
            {
                _repositoryAsync = repositoryAsync;
                _mapper = mapper;
            }

            public async Task<Response<List<TransporteDto>>> Handle(GetAllTransporteQuery request, CancellationToken cancellationToken)
            {
                var _Transporte = await _repositoryAsync.ListAsync();
                var _TransporteDto = _mapper.Map<List<TransporteDto>>(_Transporte);
                return new Response<List<TransporteDto>>(_TransporteDto);
            }

          
        }

    }

    /*public class TransporteSpecification : Specification<EndtidadDominio>
    {
        public FacturaSpecification(TipoParametro1 Parametro1, TipoParametro2 Parametro2)
        {
            Query.Where(x => x.Campo1 >= Parametro1 && x.campo2 <= Parametro2).Take(20);
        }
    }*/
}
