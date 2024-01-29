using Aplicacion.Almacen.DTOs;
using Aplicacion.Interfaces;
using Aplicacion.Wrappers;
using AutoMapper;
using Dominio.Entities.Almacen;
using FluentValidation;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Features.Almacen.Commands
{

    public class CreateAlmSalidadespachodetalleCommand : IRequest<Response<int>>
    {
        public AlmSalidadespachodetalleDto _AlmSalidadespachodetalle { get; set; }
    }

    public class CreateAlmSalidadespachodetalleCommandHandler : IRequestHandler<CreateAlmSalidadespachodetalleCommand, Response<int>>
    {
        private readonly IRepositoryAsync<AlmSalidadespachodetalle> _repositoryAsync;
        private readonly IMapper _mapper;
        public CreateAlmSalidadespachodetalleCommandHandler(IRepositoryAsync<AlmSalidadespachodetalle> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateAlmSalidadespachodetalleCommand request, CancellationToken cancellationToken)
        {
            var nuevoRegistro = _mapper.Map<AlmSalidadespachodetalle>(request._AlmSalidadespachodetalle);
            var data = await _repositoryAsync.AddAsync(nuevoRegistro);
            return new Response<int>(data.IdalmSalidadespachodetalle);
        }
    }

    public class CreateAlmSalidadespachodetalleCommandValidator : AbstractValidator<CreateAlmSalidadespachodetalleCommand>
    {
        public CreateAlmSalidadespachodetalleCommandValidator()
        {
            RuleFor(p => p._AlmSalidadespachodetalle.NumeroPallet.ToString())
                .NotEmpty().WithMessage("{PropertyName} no pude ser vacio")
                .MaximumLength(120).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");
        }
    }
}
