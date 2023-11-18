using Aplicacion.Interfaces;
using Aplicacion.Wrappers;
using Dominio.Entities;
using Dominio.Entities.Transporte;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Features.Transporte.Commands
{

    public class DeleteTransporteCommand : IRequest<Response<int>>
    {
        public int IdinsTransporte { get; set; }
    }

    public class DeleteTransporteCommandHandler : IRequestHandler<DeleteTransporteCommand, Response<int>>
    {
        private readonly IRepositoryAsync<InsTransporte> _repositoryAsync;
        public DeleteTransporteCommandHandler(IRepositoryAsync<InsTransporte> repositoryAsync)
        {
            _repositoryAsync = repositoryAsync;
        }

        public async Task<Response<int>> Handle(DeleteTransporteCommand request, CancellationToken cancellationToken)
        {
            var _Transporte = await _repositoryAsync.GetByIdAsync(request.IdinsTransporte);
            if (_Transporte == null)
            {
                throw new KeyNotFoundException("Registro no encontrado con el id");
            }
            else
            {
                await _repositoryAsync.DeleteAsync(_Transporte);
                return new Response<int>(_Transporte.IdinsTransporte);
            }
        }
    }
}
