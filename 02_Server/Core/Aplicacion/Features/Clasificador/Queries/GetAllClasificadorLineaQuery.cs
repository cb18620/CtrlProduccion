﻿using Ardalis.Specification;
using AutoMapper;
using Dominio.Entities;
using Dominio.Entities.Seguridad;
using global::Aplicacion.DTOs.Segurity;
using global::Aplicacion.Interfaces;
using global::Aplicacion.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Features.Aplicacion.Clasificador.Queries
{
    public class GetAllClasificadorLineaQuery : IRequest<Response<List<GenClasificadorDto>>>
    {
        public class GetClasificadorQueryHandler : IRequestHandler<GetAllClasificadorLineaQuery, Response<List<GenClasificadorDto>>>
        {
            private readonly IRepositoryAsync<GenClasificador> _repo;
            private readonly IMapper _mapp;
            public GetClasificadorQueryHandler(IRepositoryAsync<GenClasificador> repo, IMapper mapp)
            {
                _repo = repo;
                _mapp = mapp;
            }

            public async Task<Response<List<GenClasificadorDto>>> Handle(GetAllClasificadorLineaQuery request, CancellationToken cancellationToken)
            {
                var _resp = new Response<List<GenClasificadorDto>>();
                try
                {
                    var _resul = await _repo.ListAsync(new GetClasificadorLineaQuerySpecification(), cancellationToken);

                    _resp.Message = _resul.Count > 0 ? String.Format(Resources.Generic.Resource.QuerySucces, _resul.Count) : Resources.Generic.Resource.QueryBad;
                    _resp.Succeeded = _resul.Count > 0;
                    _resp.Data = _resul.Count > 0 ? _mapp.Map<List<GenClasificadorDto>>(_resul) : null;
                }
                catch (Exception e)
                {
                    _resp.Message = e.Message;
                    _resp.Succeeded = false;
                }

                return _resp;
            }
        }
    }
    public class GetClasificadorLineaQuerySpecification : Specification<GenClasificador>
    {
        public GetClasificadorLineaQuerySpecification()
        {
            Query.Where(x => x.IdgenClasificadortipo == (int)Enums.ClasificadorTipo.linea);
        }
    }
}


