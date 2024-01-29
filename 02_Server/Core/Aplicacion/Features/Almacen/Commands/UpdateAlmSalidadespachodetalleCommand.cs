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

    public class UpdateAlmSalidadespachodetalleCommand : IRequest<Response<int>>
    {
        public int IdalmSalidadespachodetalle { get; set; }
        //TODO: agregar parametros
    }

    public class UpdateAlmSalidadespachodetalleCommandHandler : IRequestHandler<UpdateAlmSalidadespachodetalleCommand, Response<int>>
    {
        private IRepositoryAsync<AlmSalidadespachodetalle> _repositoryAsync;
        private readonly IMapper _mapper;
        public UpdateAlmSalidadespachodetalleCommandHandler(IRepositoryAsync<AlmSalidadespachodetalle> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(UpdateAlmSalidadespachodetalleCommand request,  CancellationToken cancellationToken)
        {
            var _AlmSalidadespachodetalle = await _repositoryAsync.GetByIdAsync(request.IdalmSalidadespachodetalle);
            if (_AlmSalidadespachodetalle == null)
            {
                throw new KeyNotFoundException("Registro no encontrado");
            }
            else
            {
                _AlmSalidadespachodetalle.IdalmSalidadespachodetalle = request.IdalmSalidadespachodetalle;
                //TODO: agregar mas propiedades

                await _repositoryAsync.UpdateAsync(_AlmSalidadespachodetalle);
                return new Response<int>(_AlmSalidadespachodetalle.IdalmSalidadespachodetalle);
            }
        }
    }

    public class UpdateAlmSalidadespachodetalleCommandValidator : AbstractValidator<UpdateAlmSalidadespachodetalleCommand>
    {

        public UpdateAlmSalidadespachodetalleCommandValidator()
        {
            //TODO: agregar regla de validaciones ..
            //RuleFor(p => p.IdfactFacturacabecera)
            //    .NotEmpty().WithMessage("textomensaje0")
            //    .MaximumLength(120).WithMessage("textomensaje");
        }
    }
}
