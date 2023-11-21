using Aplicacion.DTOs.Segurity;
using Aplicacion.Interfaces;
using Aplicacion.Wrappers;
using Ardalis.Specification;
using AutoMapper;
using Dominio.Entities.Seguridad;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Features.Clasificador.Queries
{

    public class GetAllClasificadorColorProdQuery : IRequest<Response<List<GenClasificadorDto>>>
    {



        public class GetAllGenClasificadorQueryHandler : IRequestHandler<GetAllClasificadorColorProdQuery, Response<List<GenClasificadorDto>>>
        {
            private readonly IRepositoryAsync<GenClasificador> _repositoryAsync;
            private readonly IMapper _mapper;
            public GetAllGenClasificadorQueryHandler(IRepositoryAsync<GenClasificador> repositoryAsync, IMapper mapper)
            {
                _repositoryAsync = repositoryAsync;
                _mapper = mapper;
            }

            public async Task<Response<List<GenClasificadorDto>>> Handle(GetAllClasificadorColorProdQuery request, CancellationToken cancellationToken)
            {
                var _GenClasificador = await _repositoryAsync.ListAsync(new GenClasificadorColorSpecification(), cancellationToken);
                var _GenClasificadorDto = _mapper.Map<List<GenClasificadorDto>>(_GenClasificador);
                return new Response<List<GenClasificadorDto>>(_GenClasificadorDto);
            }

        }

    }

    public class GenClasificadorColorSpecification : Specification<GenClasificador>
    {
        public GenClasificadorColorSpecification()
        {
            Query.Where(x => x.IdgenClasificadortipo == (int)Enums.ClasificadorTipo.ColorEnvase);
        }
    }
}
