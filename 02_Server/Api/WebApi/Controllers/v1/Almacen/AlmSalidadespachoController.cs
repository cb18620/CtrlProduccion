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

namespace WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class AlmSalidadespachoController : BaseApiController
    {
        [HttpGet("AlmSalidadespacho")]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            return Ok(await Mediator.Send(new GetAllAlmSalidadespachoQuery()));
        }


        [HttpGet("Despacho")]
        [Authorize]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new GetAllDespachoQuery()));
        }


        [HttpPost("PosDespacho")]
        [Authorize]
        public async Task<IActionResult> Post(CreateDespachoCommand command)
        {
            return Ok(await Mediator.Send(command));
        }


        //[HttpPost]
        //[Authorize]
        //public async Task<IActionResult> Post(CreateAlmSalidadespachoCommand command)
        //{
        //    return Ok(await Mediator.Send(command));
        //}


        //[HttpDelete("{id}")]
        //[Authorize]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    return Ok(await Mediator.Send(new DeleteAlmSalidadespachoCommand { IdalmSalidadespacho = id }));
        //}



        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Put(int id, UpdateAlmSalidadespachoCommand command)
        {
            command.IdalmSalidadespacho = id; 
            try
            {
                var response = await Mediator.Send(command);
                return Ok(response); 
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
        }




    }
}
