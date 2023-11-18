using Aplicacion.DTOs.empresa;
using Aplicacion.Interfaces;
using Aplicacion.Wrappers;
using Ardalis.Specification;
using AutoMapper;
using Dominio.Entities.empresa;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Features.Empresa.Queries
{

    public class GetAllInsEmpresaQuery : IRequest<Response<List<InsEmpresaDto>>>
    {
        


        public class GetAllInsEmpresaQueryHandler : IRequestHandler<GetAllInsEmpresaQuery, Response<List<InsEmpresaDto>>>
        {
            private readonly IRepositoryAsync<InsEmpresa> _repositoryAsync;
            private readonly IMapper _mapper;
            public GetAllInsEmpresaQueryHandler(IRepositoryAsync<InsEmpresa> repositoryAsync, IMapper mapper)
            {
                _repositoryAsync = repositoryAsync;
                _mapper = mapper;
            }

            public async Task<Response<List<InsEmpresaDto>>> Handle(GetAllInsEmpresaQuery request, CancellationToken cancellationToken)
            {
                var _InsEmpresa = await _repositoryAsync.ListAsync(new InsEmpresaSpecification(), cancellationToken);
                var _InsEmpresaDto = _mapper.Map<List<InsEmpresaDto>>(_InsEmpresa);
                return new Response<List<InsEmpresaDto>>(_InsEmpresaDto);
            }

        }

    }

    public class InsEmpresaSpecification : Specification<InsEmpresa>
    {
        public InsEmpresaSpecification()
        {
          
        }
    }
}
