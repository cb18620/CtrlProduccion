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
    public class DeleteAlmCabeceraPalletsCommand : IRequest<Response<int>>
    {
        public int IdAlmCabeceraPallets { get; set; }
    }

    public class DeleteAlmCabeceraPalletsCommandHandler : IRequestHandler<DeleteAlmCabeceraPalletsCommand, Response<int>>
    {
        private readonly IRepositoryAsync<AlmCabeceraPallets> _repositoryAsync;
        public DeleteAlmCabeceraPalletsCommandHandler(IRepositoryAsync<AlmCabeceraPallets> repositoryAsync)
        {
            _repositoryAsync = repositoryAsync;
        }

        public async Task<Response<int>> Handle(DeleteAlmCabeceraPalletsCommand request, CancellationToken cancellationToken)
        {
            var _AlmCabeceraPallets = await _repositoryAsync.GetByIdAsync(request.IdAlmCabeceraPallets);
            if (_AlmCabeceraPallets == null)
            {
                throw new KeyNotFoundException("Registro no encontrado con el id");
            }
            else
            {
                await _repositoryAsync.DeleteAsync(_AlmCabeceraPallets);
                return new Response<int>(_AlmCabeceraPallets.IdAlmCabeceraPallets);
            }
        }


    }
}
