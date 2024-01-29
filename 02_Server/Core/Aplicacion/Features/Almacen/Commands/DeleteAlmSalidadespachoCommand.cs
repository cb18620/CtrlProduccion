using Aplicacion.Interfaces;
using Aplicacion.Wrappers;
using Dominio.Entities.Almacen;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Features.Almacen.Commands
{

    public class DeleteAlmSalidadespachoCommand : IRequest<Response<int>>
    {
        public int IdalmSalidadespacho { get; set; }
    }

    public class DeleteAlmSalidadespachoCommandHandler : IRequestHandler<DeleteAlmSalidadespachoCommand, Response<int>>
    {
        private readonly IRepositoryAsync<AlmSalidadespacho> _repositoryAsync;
        public DeleteAlmSalidadespachoCommandHandler(IRepositoryAsync<AlmSalidadespacho> repositoryAsync)
        {
            _repositoryAsync = repositoryAsync;
        }

        public async Task<Response<int>> Handle(DeleteAlmSalidadespachoCommand request,  CancellationToken cancellationToken)
        {
            var _AlmSalidadespacho = await _repositoryAsync.GetByIdAsync(request.IdalmSalidadespacho);
            if (_AlmSalidadespacho == null)
            {
                throw new KeyNotFoundException("Registro no encontrado con el id");
            }
            else
            {
                await _repositoryAsync.DeleteAsync(_AlmSalidadespacho);
                return new Response<int>(_AlmSalidadespacho.IdalmSalidadespacho);
            }
        }
    }
}
