using Aplicacion.Almacen.DTOs;
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


    public class GetAllAlmSalidadespachodetalleQuery : IRequest<Response<List<AlmSalidadespachodetalleDto>>>
    {
        public int idorden { get; set; } 
   


        public class GetAllAlmSalidadespachodetalleQueryHandler : IRequestHandler<GetAllAlmSalidadespachodetalleQuery, Response<List<AlmSalidadespachodetalleDto>>>
        {
            private readonly IRepositoryAsync<AlmSalidadespachodetalle> _repositoryAsync;
            private readonly IMapper _mapper;
            public GetAllAlmSalidadespachodetalleQueryHandler(IRepositoryAsync<AlmSalidadespachodetalle> repositoryAsync, IMapper mapper)
            {
                _repositoryAsync = repositoryAsync;
                _mapper = mapper;
            }

            public async Task<Response<List<AlmSalidadespachodetalleDto>>> Handle(GetAllAlmSalidadespachodetalleQuery request,  CancellationToken cancellationToken)
            {
                var _AlmSalidadespachodetalle = await _repositoryAsync.ListAsync(new AlmSalidadespachodetalleSpecification(request.idorden));
                var _AlmSalidadespachodetalleDto = _mapper.Map<List<AlmSalidadespachodetalleDto>>(_AlmSalidadespachodetalle);
                return new Response<List<AlmSalidadespachodetalleDto>>(_AlmSalidadespachodetalleDto);
            }
        }

    }

    public class AlmSalidadespachodetalleSpecification : Specification<AlmSalidadespachodetalle>
    {
        public AlmSalidadespachodetalleSpecification(int idorden)
        {
            Query.Where(v => v.IdalmSalidadespacho == idorden).Take(20);
        }
    }


}
