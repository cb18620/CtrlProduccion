using Aplicacion.DTOs;
using Aplicacion.Interfaces;
using Aplicacion.Resources.RefCursors;
using Aplicacion.Wrappers;
using Ardalis.Specification;
using AutoMapper;
using Dominio.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Aplicacion.Features.Almacen.Queries
{


    public class GetAllVstockpalletQuery : IRequest<Response<List<VpalletalmacenDto>>>
    {
        public int idsolicitud { get; set; }



        public class GetAllVstockpalletQueryHandler : IRequestHandler<GetAllVstockpalletQuery, Response<List<VpalletalmacenDto>>>
        {
            private readonly IRepositoryAsync<VpalletalmacenDto> _repo;
            private readonly IMapper _mapper;
            public GetAllVstockpalletQueryHandler(IRepositoryAsync<VpalletalmacenDto> repo, IMapper mapper)
            {
                _repo = repo;
                _mapper = mapper;
            }

            public async Task<Response<List<VpalletalmacenDto>>> Handle(GetAllVstockpalletQuery request, CancellationToken cancellationToken)
            {
                /* var _Vstockpallet = await _repositoryAsync.ListAsync(new VstockpalletSpecification(request.idsolicitud));
                 var _VstockpalletDto = _mapper.Map<List<VpalletalmacenDto>>(_Vstockpallet);
                 return new Response<List<VpalletalmacenDto>>(_VstockpalletDto);
                 */
                var _resp = new Response<List<VpalletalmacenDto>>();
                try
                {
                    var _result = await _repo.CallFunctionReFCursor(Resource.srv_stockpallet, request.idsolicitud);
                    _resp.Message = _result.Count > 0 ? String.Format(Resources.Generic.Resource.QuerySucces, _result.Count.ToString()) : Resources.Generic.Resource.QueryBad;
                    _resp.Succeeded = (_result.Count > 0);
                    _resp.Data = _result.Count > 0 ? _result : null;
                }
                catch (System.Exception e)
                {
                    _resp.Message = e.Message;
                    _resp.Succeeded = false;
                    _resp.Data = null;
                }

                return _resp;
            }
        }

    }




}
