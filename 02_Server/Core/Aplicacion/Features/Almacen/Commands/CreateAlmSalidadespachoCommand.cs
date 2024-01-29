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

    public class CreateAlmSalidadespachoCommand : IRequest<Response<int>>
    {
        public AlmSalidadespachoDto _AlmSalidadespacho { get; set; }
    }

    public class CreateAlmSalidadespachoCommandHandler : IRequestHandler<CreateAlmSalidadespachoCommand, Response<int>>
    {
        private readonly IRepositoryAsync<AlmSalidadespacho> _repositoryAsync;
        private readonly IMapper _mapper;
        public CreateAlmSalidadespachoCommandHandler(IRepositoryAsync<AlmSalidadespacho> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateAlmSalidadespachoCommand request,  CancellationToken cancellationToken)
        {
            var nuevoRegistro = _mapper.Map<AlmSalidadespacho>(request._AlmSalidadespacho);
            var data = await _repositoryAsync.AddAsync(nuevoRegistro);
            return new Response<int>(data.IdalmSalidadespacho);
        }
    }

    public class CreateAlmSalidadespachoCommandValidator : AbstractValidator<CreateAlmSalidadespachoCommand>
    {
        public CreateAlmSalidadespachoCommandValidator()
        {
            RuleFor(p => p._AlmSalidadespacho.NumeroListaempaque)
                .NotEmpty().WithMessage("{PropertyName} no pude ser vacio")
                .MaximumLength(120).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");
        }
    }
}
