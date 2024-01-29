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

    public class GetAllVpalletalmacenQuery : IRequest<Response<List<DTOs.VpalletalmacenDto>>>
    {
        


        public class GetAllVpalletalmacenQueryHandler : IRequestHandler<GetAllVpalletalmacenQuery, Response<List<DTOs.VpalletalmacenDto>>>
        {
            private readonly IRepositoryAsync<Vpalletalmacen> _repositoryAsync;
            private readonly IMapper _mapper;
            public GetAllVpalletalmacenQueryHandler(IRepositoryAsync<Vpalletalmacen> repositoryAsync, IMapper mapper)
            {
                _repositoryAsync = repositoryAsync;
                _mapper = mapper;
            }

            public async Task<Response<List<DTOs.VpalletalmacenDto>>> Handle(GetAllVpalletalmacenQuery request,  CancellationToken cancellationToken)
            {
                var _Vpalletalmacen = await _repositoryAsync.ListAsync();
                var _VpalletalmacenDto = _mapper.Map<List<DTOs.VpalletalmacenDto>>(_Vpalletalmacen);
                return new Response<List<DTOs.VpalletalmacenDto>>(_VpalletalmacenDto);
            }
        }

    }

 
}
