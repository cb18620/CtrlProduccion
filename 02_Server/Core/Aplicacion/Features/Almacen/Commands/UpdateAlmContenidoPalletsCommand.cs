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

    public class UpdateAlmContenidoPalletsCommand : IRequest<Response<int>>
    {
        public int IdAlmContenidoPallets { get; set; }
        public int tipo { get; set; }
        public string Observacion { get; set; }
        public string Analisis { get; set; }
        public int? Estadolectura { get; set; }
        //TODO: agregar parametros
    }

    public class UpdateAlmContenidoPalletsCommandHandler : IRequestHandler<UpdateAlmContenidoPalletsCommand, Response<int>>
    {
        private IRepositoryAsync<AlmContenidoPallets> _repositoryAsync;
        private readonly IMapper _mapper;
        public UpdateAlmContenidoPalletsCommandHandler(IRepositoryAsync<AlmContenidoPallets> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(UpdateAlmContenidoPalletsCommand request,  CancellationToken cancellationToken)
        {
            var _AlmContenidoPallets = await _repositoryAsync.GetByIdAsync(request.IdAlmContenidoPallets);
            if (_AlmContenidoPallets == null)
            {
                throw new KeyNotFoundException("Registro no encontrado");
            }
            else
            {
                _AlmContenidoPallets.IdAlmContenidoPallets = request.IdAlmContenidoPallets;
                _AlmContenidoPallets.Tipo = request.tipo;
                _AlmContenidoPallets.Analisis = request.Analisis;
                _AlmContenidoPallets.Observacion = request.Observacion;
                _AlmContenidoPallets.Estadolectura = request.Estadolectura;
                //TODO: agregar mas propiedades

                await _repositoryAsync.UpdateAsync(_AlmContenidoPallets);
                return new Response<int>(_AlmContenidoPallets.IdAlmContenidoPallets);
            }
        }
    }

    public class UpdateAlmContenidoPalletsCommandValidator : AbstractValidator<UpdateAlmContenidoPalletsCommand>
    {

        public UpdateAlmContenidoPalletsCommandValidator()
        {
            //TODO: agregar regla de validaciones ..
            //RuleFor(p => p.IdfactFacturacabecera)
            //    .NotEmpty().WithMessage("textomensaje0")
            //    .MaximumLength(120).WithMessage("textomensaje");
        }
    } 
}
