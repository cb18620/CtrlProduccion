using Aplicacion.DTOs.Almacen;
using Aplicacion.Features.Almacen.Queries;
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

    public class CreateAlmContenidoPalletsCommand : IRequest<Response<int>>
    {
        public AlmContenidoPalletsDto _AlmContenidoPallets { get; set; }
    }

    public class CreateAlmContenidoPalletsCommandHandler : IRequestHandler<CreateAlmContenidoPalletsCommand, Response<int>>
    {
        private readonly IRepositoryAsync<AlmContenidoPallets> _repositoryAsync;
        private readonly IMapper _mapper;
        public CreateAlmContenidoPalletsCommandHandler(IRepositoryAsync<AlmContenidoPallets> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;

        }

        public async Task<Response<int>> Handle(CreateAlmContenidoPalletsCommand request, CancellationToken cancellationToken)
        {

            var nuevoRegistro = _mapper.Map<AlmContenidoPallets>(request._AlmContenidoPallets);
            var data = await _repositoryAsync.AddAsync(nuevoRegistro);
            return new Response<int>(data.IdAlmContenidoPallets);
        }

       
    }

    public class CreateAlmContenidoPalletsCommandValidator : AbstractValidator<CreateAlmContenidoPalletsCommand>
    {
        public CreateAlmContenidoPalletsCommandValidator()
        {
            RuleFor(p => p._AlmContenidoPallets.Turno.ToString())
                .NotEmpty().WithMessage("{PropertyName} no pude ser vacio")
                .MaximumLength(120).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");

            RuleFor(p => p._AlmContenidoPallets.Fecha.ToString())
              .NotEmpty().WithMessage("{PropertyName} no pude ser vacio")
              .MaximumLength(120).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");
            RuleFor(p => p._AlmContenidoPallets.Turno.ToString())
              .NotEmpty().WithMessage("{PropertyName} no pude ser vacio")
              .MaximumLength(120).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");
        }
    }
}
