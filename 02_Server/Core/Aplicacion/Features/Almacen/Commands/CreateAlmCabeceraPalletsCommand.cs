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
    public class CreateAlmCabeceraPalletsCommand : IRequest<Response<int>>
    {
        public AlmCabeceraPalletsDto _AlmCabeceraPallets { get; set; }
    }

    public class CreateAlmCabeceraPalletsCommandHandler : IRequestHandler<CreateAlmCabeceraPalletsCommand, Response<int>>
    {
        private readonly IRepositoryAsync<AlmCabeceraPallets> _repositoryAsync;
        private readonly IMapper _mapper;
        public CreateAlmCabeceraPalletsCommandHandler(IRepositoryAsync<AlmCabeceraPallets> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateAlmCabeceraPalletsCommand request, CancellationToken cancellationToken)
        {
            var nuevoRegistro = _mapper.Map<AlmCabeceraPallets>(request._AlmCabeceraPallets);
            var data = await _repositoryAsync.AddAsync(nuevoRegistro);
            return new Response<int>(data.IdAlmCabeceraPallets);
        }


    }

    public class CreateAlmCabeceraPalletsCommandValidator : AbstractValidator<CreateAlmCabeceraPalletsCommand>
    {
        public CreateAlmCabeceraPalletsCommandValidator()
        {
            //RuleFor(p => p._AlmCabeceraPallets.Molde.ToString())
            //    .NotEmpty().WithMessage("{PropertyName} no pude ser vacio")
            //    .MaximumLength(120).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");
        }
    }
}
