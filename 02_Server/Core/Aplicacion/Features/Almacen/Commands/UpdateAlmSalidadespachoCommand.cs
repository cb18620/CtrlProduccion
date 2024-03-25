using Aplicacion.Interfaces;
using Aplicacion.Wrappers;
using AutoMapper;
using Dominio.Entities.Almacen;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Aplicacion.Features.Almacen.Commands
{

    public class UpdateAlmSalidadespachoCommand : IRequest<Response<int>>
    {
        public int IdalmSalidadespacho { get; set; }
        public int Estado { get; set; }
        
    }

    public class UpdateAlmSalidadespachoCommandHandler : IRequestHandler<UpdateAlmSalidadespachoCommand, Response<int>>
    {
        private IRepositoryAsync<AlmSalidadespacho> _repositoryAsync;
        private readonly IMapper _mapper;
        public UpdateAlmSalidadespachoCommandHandler(IRepositoryAsync<AlmSalidadespacho> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(UpdateAlmSalidadespachoCommand request,  CancellationToken cancellationToken)
        {
            var _AlmSalidadespacho = await _repositoryAsync.GetByIdAsync(request.IdalmSalidadespacho);
            if (_AlmSalidadespacho == null)
            {
                throw new KeyNotFoundException("Registro no encontrado");
            }
            else
            {
                _AlmSalidadespacho.IdalmSalidadespacho = request.IdalmSalidadespacho;
                _AlmSalidadespacho.Estado = request.Estado; 
                //TODO: agregar mas propiedades

                await _repositoryAsync.UpdateAsync(_AlmSalidadespacho);
                return new Response<int>(_AlmSalidadespacho.IdalmSalidadespacho);
            }
        }
    }

    public class UpdateAlmSalidadespachoCommandValidator : AbstractValidator<UpdateAlmSalidadespachoCommand>
    {

        public UpdateAlmSalidadespachoCommandValidator()
        {
            
        }
    }
}
