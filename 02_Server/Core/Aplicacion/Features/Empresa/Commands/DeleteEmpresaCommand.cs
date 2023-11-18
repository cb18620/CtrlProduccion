using Aplicacion.Interfaces;
using Aplicacion.Wrappers;
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

    public class DeleteEmpresaCommand : IRequest<Response<int>>
    {
        public int IdinsEmpresa { get; set; }
    }

    public class DeleteEmpresaCommandHandler : IRequestHandler<DeleteEmpresaCommand, Response<int>>
    {
        private readonly IRepositoryAsync<InsEmpresa> _repositoryAsync;
        public DeleteEmpresaCommandHandler(IRepositoryAsync<InsEmpresa> repositoryAsync)
        {
            _repositoryAsync = repositoryAsync;
        }

        public async Task<Response<int>> Handle(DeleteEmpresaCommand request, CancellationToken cancellationToken)
        {
            var _Empresa = await _repositoryAsync.GetByIdAsync(request.IdinsEmpresa);
            if (_Empresa == null)
            {
                throw new KeyNotFoundException("Registro no encontrado con el id");
            }
            else
            {
                await _repositoryAsync.DeleteAsync(_Empresa);
                return new Response<int>(_Empresa.IdinsEmpresa);
            }
        }
    }
}
