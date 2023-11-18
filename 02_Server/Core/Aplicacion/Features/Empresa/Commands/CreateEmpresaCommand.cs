using Aplicacion.DTOs.empresa;
using Aplicacion.Interfaces;
using Aplicacion.Wrappers;
using AutoMapper;
using Dominio.Entities;
using Dominio.Entities.empresa;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Features.Empresa.Commands
{

    public class CreateEmpresaCommand : IRequest<Response<int>>
    {
        public InsEmpresaDto _Empresa { get; set; }
    }

    public class CreateEmpresaCommandHandler : IRequestHandler<CreateEmpresaCommand, Response<int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CreateEmpresaCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateEmpresaCommand request, CancellationToken cancellationToken)
        {
            var nuevoRegistro = _mapper.Map<InsEmpresa>(request._Empresa);
            var data = await _unitOfWork.IUnitAddAsync(nuevoRegistro, cancellationToken);
            await _unitOfWork.commit(cancellationToken);
            return new Response<int>(data.IdinsEmpresa) { Message = Resources.Generic.Resource.SaveSuccess, Succeeded = true };
        }

       
    }

    public class CreateEmpresaCommandValidator : AbstractValidator<CreateEmpresaCommand>
    {
        public CreateEmpresaCommandValidator()
        {
            RuleFor(p => p._Empresa.Nit)
                .NotEmpty().WithMessage("{PropertyName} no pude ser vacio");
        }
    }
}
