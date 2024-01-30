using Aplicacion.Features.Almacen.Commands;
using Aplicacion.Features.Almacen.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapi.Controllers.v1;

namespace WebApi.Controllers.v1.Almacen 
{
    [ApiVersion("1.0")]
    public class AlmSalidadespachodetalleController : BaseApiController
    {
        [HttpGet("AlmSalidadespachodetalle")]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            return Ok(await Mediator.Send(new GetAllAlmSalidadespachodetalleQuery()));
        }


        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Post(CreateAlmSalidadespachodetalleCommand command)
        {
                       

            return Ok(await Mediator.Send(command));



        }


        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteAlmSalidadespachodetalleCommand { IdalmSalidadespachodetalle = id }));
        }



        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Put(int id, UpdateAlmSalidadespachodetalleCommand command)
        {
            if (id != command.IdalmSalidadespachodetalle)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }



        [HttpGet("Vpalletalmacen")]
        [Authorize]
        public async Task<IActionResult> Vpalletalmacen()
        {
            return Ok(await Mediator.Send(new GetAllVpalletalmacenQuery()));
        }

        [HttpGet("Vpalletalmacend/{idorden}")]
        [Authorize]
        public async Task<IActionResult> Vpalletalmacend(int idorden)
        {
            return Ok(await Mediator.Send(new GetAllVpalletalmacendQuery
            {
                idorden = idorden

            }));
        }

        [HttpGet("palletalmacen/{idorden}")]
        public async Task<IActionResult> Palletalmacen(int idorden)
        {
            return Ok(await Mediator.Send(new GetAllAlmSalidadespachodetalleQuery{idorden= idorden }));

        }

    }
}
