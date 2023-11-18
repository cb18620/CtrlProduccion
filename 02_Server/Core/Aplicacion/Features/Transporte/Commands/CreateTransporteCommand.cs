using Aplicacion.DTOs;
using Aplicacion.DTOs.Transporte;
using Aplicacion.Interfaces;
using Aplicacion.Wrappers;
using AutoMapper;
using Dominio.Entities;
using Dominio.Entities.Transporte;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Features.Transporte.Commands
{

    public class CreateTransporteCommand : IRequest<Response<int>>
    {
        public TransporteDto _Transporte { get; set; }
    }

    public class CreateTransporteCommandHandler : IRequestHandler<CreateTransporteCommand, Response<int>>
    {
        private readonly IRepositoryAsync<InsTransporte> _repositoryAsync;
        private readonly IMapper _mapper;
        public CreateTransporteCommandHandler(IRepositoryAsync<InsTransporte> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateTransporteCommand request, CancellationToken cancellationToken)
        {
            var nuevoRegistro = _mapper.Map<InsTransporte>(request._Transporte);
            var data = await _repositoryAsync.AddAsync(nuevoRegistro);
            return new Response<int>(data.IdinsTransporte);
        }

     
    }

    public class CreateTransporteCommandValidator : AbstractValidator<CreateTransporteCommand>
    {
        public CreateTransporteCommandValidator()
        {
            RuleFor(p => p._Transporte.Matricula)
                .NotEmpty().WithMessage("{PropertyName} no pude ser vacio");
        }
    }
}
