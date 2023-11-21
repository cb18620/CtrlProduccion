using Aplicacion.Features.Almacen.Commands;
using Aplicacion.Features.Almacen.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Webapi.Controllers.v1;

namespace WebApi.Controllers.v1.Almacen
{
    [ApiVersion("1.0")]
    public class AlmContenidoPalletsController : BaseApiController
    {

        [HttpGet("DetallePallet/{idCabecera}")]
        [Authorize]
        public async Task<IActionResult> DetallePallet(int idCabecera)
        {
            return Ok(await Mediator.Send(new GetAllAlmContenidoPalletsQuery { idCabecera = idCabecera }));
        }

        [HttpGet("DetallePalletproceso/{idCabecera}")]
        [Authorize]
        public async Task<IActionResult> DetallePalletproceso(int idCabecera)
        {
            return Ok(await Mediator.Send(new GetAllAlmContenidoPalletsProcesoQuery { idCabecera = idCabecera }));
        }
        [HttpGet("DetalleControl/{idCabecera},{NumPallet}")]
        [Authorize]
        public async Task<IActionResult> DetalleControl(int NumPallet, int idCabecera)
        {
            return Ok(await Mediator.Send(new GetAllAlmContenidoPalletsControlQuery { idCabecera = idCabecera, NumPallet = NumPallet }));
        }


      

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Put(int id, UpdateAlmContenidoPalletsCommand command)
        {
            if (id != command.IdAlmContenidoPallets)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteAlmContenidoPalletsCommand { IdAlmContenidoPallets = id }));
        }
    }
}
