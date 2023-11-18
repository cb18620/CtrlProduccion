using Aplicacion.Interfaces;
using Aplicacion.Wrappers;
using AutoMapper;
using Dominio.Entities;
using Dominio.Entities.empresa;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Aplicacion.Features.Empresa.Commands
{

    public class UpdateEmpresaCommand : IRequest<Response<int>>
    {
        public int IdinsEmpresa { get; set; }
        public string Nit{ get; set; }
        public string NombreRepresentante { get; set; }
        public string Ubicacion { get; set; }
        public string RazonSocial { get; set; }
        //TODO: agregar parametros
    }

    public class UpdateEmpresaCommandHandler : IRequestHandler<UpdateEmpresaCommand, Response<int>>
    {
        private IRepositoryAsync<InsEmpresa> _repositoryAsync;
        private readonly IMapper _mapper;
        public UpdateEmpresaCommandHandler(IRepositoryAsync<InsEmpresa> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(UpdateEmpresaCommand request, CancellationToken cancellationToken)
        {
            var _Empresa = await _repositoryAsync.GetByIdAsync(request.IdinsEmpresa);
            if (_Empresa == null)
            {
                throw new KeyNotFoundException("Registro no encontrado");
            }
            else
            {
                _Empresa.Nit = request.Nit;
                _Empresa.NombreRepresentante = request.NombreRepresentante;
                _Empresa.Ubicacion = request.Ubicacion;
                _Empresa.RazonSocial = request.RazonSocial;
                //TODO: agregar mas propiedades

                await _repositoryAsync.UpdateAsync(_Empresa);
                return new Response<int>(_Empresa.IdinsEmpresa);
            }
        }
    }

    
}
