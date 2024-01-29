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

    public class DeleteAlmSalidadespachodetalleCommand : IRequest<Response<int>>
    {
        public int IdalmSalidadespachodetalle { get; set; }
    }

    public class DeleteAlmSalidadespachodetalleCommandHandler : IRequestHandler<DeleteAlmSalidadespachodetalleCommand, Response<int>>
    {
        private readonly IRepositoryAsync<AlmSalidadespachodetalle> _repositoryAsync;
        public DeleteAlmSalidadespachodetalleCommandHandler(IRepositoryAsync<AlmSalidadespachodetalle> repositoryAsync)
        {
            _repositoryAsync = repositoryAsync;
        }

        public async Task<Response<int>> Handle(DeleteAlmSalidadespachodetalleCommand request,  CancellationToken cancellationToken)
        {
            var _AlmSalidadespachodetalle = await _repositoryAsync.GetByIdAsync(request.IdalmSalidadespachodetalle);
            if (_AlmSalidadespachodetalle == null)
            {
                throw new KeyNotFoundException("Registro no encontrado con el id");
            }
            else
            {
                await _repositoryAsync.DeleteAsync(_AlmSalidadespachodetalle);
                return new Response<int>(_AlmSalidadespachodetalle.IdalmSalidadespachodetalle);
            }
        }
    }
}
