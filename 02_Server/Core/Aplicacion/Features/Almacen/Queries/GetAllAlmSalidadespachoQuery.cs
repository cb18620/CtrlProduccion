using Aplicacion.Almacen.DTOs;
using Aplicacion.Interfaces;
using Aplicacion.Interfaces.Repositories;
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

    public class GetAllAlmSalidadespachoQuery : IRequest<Response<List<AlmSalidadespachoDto>>>
    {
   

        public class GetAllAlmSalidadespachoQueryHandler : IRequestHandler<GetAllAlmSalidadespachoQuery, Response<List<AlmSalidadespachoDto>>>
        {
            private readonly ISalidadespachoRepository _repo;
            public GetAllAlmSalidadespachoQueryHandler(ISalidadespachoRepository _rep)
            {
                _repo = _rep;
            }

            public async Task<Response<List<AlmSalidadespachoDto>>> Handle(GetAllAlmSalidadespachoQuery request,  CancellationToken cancellationToken)
            {
                var _Result = new Response<List<AlmSalidadespachoDto>>();
                try
                {
                    _Result = await _repo.GetSalidadespacho();
                    _Result.Message = _Result.Data.Count > 0 ? String.Format(Resources.Generic.Resource.QuerySucces, _Result.Data.Count) : Resources.Generic.Resource.QueryBad;
                    _Result.Succeeded = _Result.Data.Count > 0;
                }
                catch (Exception e)
                {
                    _Result.Message = e.Message;
                    _Result.Succeeded = false;
                }

                return _Result;
            }
        }

    }


}
