using Aplicacion.DTOs;
using Aplicacion.Interfaces;
using Aplicacion.Wrappers;
using Ardalis.Specification;
using AutoMapper;
using Dominio.Entities.Vistas;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Aplicacion.Features.Almacen.Queries
{

    public class GetAllVpalletalmacendQuery : IRequest<Response<List<VpalletalmacendDto>>>
    {

        public int idorden { get; set; }

        public class GetAllVpalletalmacenQueryHandler : IRequestHandler<GetAllVpalletalmacendQuery, Response<List<DTOs.VpalletalmacendDto>>>
        {
            private readonly IRepositoryAsync<Vpalletalmacend> _repositoryAsync;
            private readonly IMapper _mapper;
            public GetAllVpalletalmacenQueryHandler(IRepositoryAsync<Vpalletalmacend> repositoryAsync, IMapper mapper)
            {
                _repositoryAsync = repositoryAsync;
                _mapper = mapper;
            }

            public async Task<Response<List<DTOs.VpalletalmacendDto>>> Handle(GetAllVpalletalmacendQuery request, CancellationToken cancellationToken)
            {
                var _Vpalletalmacen = await _repositoryAsync.ListAsync(new ObjetoSpecificationOrden(request.idorden));
                var _VpalletalmacenDto = _mapper.Map<List<DTOs.VpalletalmacendDto>>(_Vpalletalmacen);
                return new Response<List<DTOs.VpalletalmacendDto>>(_VpalletalmacenDto);
            }
        }

    }

    public class ObjetoSpecificationOrden : Specification<Vpalletalmacend>
    {
        public ObjetoSpecificationOrden(int idorden)
        {
            Query.Where(x => x.IdalmSalidadespacho == idorden);
        }
    }



}
