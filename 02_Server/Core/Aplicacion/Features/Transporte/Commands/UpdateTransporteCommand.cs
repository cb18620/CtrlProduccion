using Aplicacion.Features.Aplicacion.Parametricas.Commands;
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

    public class UpdateTransporteCommand : IRequest<Response<int>>
    {
        public int IdinsTransporte { get; set; }
        //TODO: agregar parametros
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public string NombreTransportista { get; set; }
        public string NroLicencia { get; set; }
        public string Categoria { get; set; }
        public string largo { get; set; }
        public string Ancho { get; set; }
        public int? IdinsEmpresa { get; set; }
        public bool VerDetalle { get; set; }
    }

    public class UpdateTransporteCommandHandler : IRequestHandler<UpdateTransporteCommand, Response<int>>
    {
        private IRepositoryAsync<InsTransporte> _repositoryAsync;
        private readonly IMapper _mapper;
        public UpdateTransporteCommandHandler(IRepositoryAsync<InsTransporte> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(UpdateTransporteCommand request, CancellationToken cancellationToken)
        {
            var _Transporte = await _repositoryAsync.GetByIdAsync(request.IdinsTransporte);
            if (_Transporte == null)
            {
                throw new KeyNotFoundException("Registro no encontrado");
            }
            else
            {
                _Transporte.IdinsTransporte = request.IdinsTransporte;
                _Transporte.Matricula = request.Matricula;
                _Transporte.Marca = request.Marca;
                _Transporte.Color = request.Color;
                _Transporte.NombreTransportista = request.NombreTransportista;
                _Transporte.NroLicencia = request.NroLicencia;
                _Transporte.Categoria = request.Categoria;
                _Transporte.largo = request.largo;
                _Transporte.Ancho = request.Ancho;
                //TODO: agregar mas propiedades

                await _repositoryAsync.UpdateAsync(_Transporte);
                return new Response<int>(_Transporte.IdinsTransporte);
            }
        }
    }

    public class UpdateTransporteCommandValidator : AbstractValidator<UpdateTransporteCommand>
    {
        public UpdateTransporteCommandValidator()
        {
            //TODO: agregar regla de validaciones ..
            //RuleFor(p => p.IdfactFacturacabecera)
            //    .NotEmpty().WithMessage("textomensaje0")
            //    .MaximumLength(120).WithMessage("textomensaje");
        }
    }
}
