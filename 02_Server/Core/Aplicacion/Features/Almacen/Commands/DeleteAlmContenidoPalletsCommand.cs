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

    public class DeleteAlmContenidoPalletsCommand : IRequest<Response<int>>
    {
        public int IdAlmContenidoPallets { get; set; }
    }

    public class DeleteAlmContenidoPalletsCommandHandler : IRequestHandler<DeleteAlmContenidoPalletsCommand, Response<int>>
    {
        private readonly IRepositoryAsync<AlmContenidoPallets> _repositoryAsync;
        public DeleteAlmContenidoPalletsCommandHandler(IRepositoryAsync<AlmContenidoPallets> repositoryAsync)
        {
            _repositoryAsync = repositoryAsync;
        }

        public async Task<Response<int>> Handle(DeleteAlmContenidoPalletsCommand request,  CancellationToken cancellationToken)
        {
            var _AlmContenidoPallets = await _repositoryAsync.GetByIdAsync(request.IdAlmContenidoPallets);
            if (_AlmContenidoPallets == null)
            {
                throw new KeyNotFoundException("Registro no encontrado con el id");
            }
            else
            {
                await _repositoryAsync.DeleteAsync(_AlmContenidoPallets);
                return new Response<int>(_AlmContenidoPallets.IdAlmContenidoPallets);
            }
        }

    }

}
