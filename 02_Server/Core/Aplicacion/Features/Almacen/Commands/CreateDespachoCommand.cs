using Aplicacion.DTOs.Almacen;
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
    public class CreateDespachoCommand : IRequest<Response<int>>
    {
        public DespachoDto _DespachoPallets { get; set; }
    }

    public class CreateDespachoCommandHandler : IRequestHandler<CreateDespachoCommand, Response<int>>
    {
        private readonly IRepositoryAsync<AlmSalidadespacho> _repositoryAsync;
        private readonly IMapper _mapper;
        public CreateDespachoCommandHandler(IRepositoryAsync<AlmSalidadespacho> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateDespachoCommand request, CancellationToken cancellationToken)
        {
            var nuevoRegistro = _mapper.Map<AlmSalidadespacho>(request._DespachoPallets);
            var data = await _repositoryAsync.AddAsync(nuevoRegistro);
            return new Response<int>(data.IdalmSalidadespacho);
        }


    }

    public class CreateDespachoCommandValidator : AbstractValidator<CreateDespachoCommand>
    {
        public CreateDespachoCommandValidator()
        {
            //RuleFor(p => p._AlmCabeceraPallets.Molde.ToString())
            //    .NotEmpty().WithMessage("{PropertyName} no pude ser vacio")
            //    .MaximumLength(120).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");
        }
    }
}
