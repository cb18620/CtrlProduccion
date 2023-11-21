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
    public class UpdateAlmCabeceraPalletsCommand : IRequest<Response<int>>
    {
        public int IdAlmCabeceraPallets { get; set; }
        //TODO: agregar parametros
    }

    public class UpdateAlmCabeceraPalletsCommandHandler : IRequestHandler<UpdateAlmCabeceraPalletsCommand, Response<int>>
    {
        private IRepositoryAsync<AlmCabeceraPallets> _repositoryAsync;
        private readonly IMapper _mapper;
        public UpdateAlmCabeceraPalletsCommandHandler(IRepositoryAsync<AlmCabeceraPallets> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(UpdateAlmCabeceraPalletsCommand request, CancellationToken cancellationToken)
        {
            var _AlmCabeceraPallets = await _repositoryAsync.GetByIdAsync(request.IdAlmCabeceraPallets);
            if (_AlmCabeceraPallets == null)
            {
                throw new KeyNotFoundException("Registro no encontrado");
            }
            else
            {
                _AlmCabeceraPallets.IdAlmCabeceraPallets = request.IdAlmCabeceraPallets;
                //TODO: agregar mas propiedades

                await _repositoryAsync.UpdateAsync(_AlmCabeceraPallets);
                return new Response<int>(_AlmCabeceraPallets.IdAlmCabeceraPallets);
            }
        }


    }

    public class UpdateAlmCabeceraPalletsCommandValidator : AbstractValidator<UpdateAlmCabeceraPalletsCommand>
    {

        public UpdateAlmCabeceraPalletsCommandValidator()
        {
            //TODO: agregar regla de validaciones ..
            //RuleFor(p => p.IdfactFacturacabecera)
            //    .NotEmpty().WithMessage("textomensaje0")
            //    .MaximumLength(120).WithMessage("textomensaje");
        }
    }
}
