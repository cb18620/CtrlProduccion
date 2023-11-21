using Aplicacion.Features.Almacen.Commands;
using Aplicacion.Features.Almacen.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Webapi.Controllers.v1;

namespace WebApi.Controllers.v1.Almacen
{
    [ApiVersion("1.0")]
    public class AlmCabeceraPalletsController : BaseApiController
    {
        [HttpGet("ListaCabecera")]
        [Authorize]
        public async Task<IActionResult> GetCabecera()
        {
            return Ok(await Mediator.Send(new GetAllAlmCabeceraPalletQuery()));
        }

        [HttpGet()]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            return Ok(await Mediator.Send(new GetAllAlmCabeceraPalletsQuery()));
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Post(CreateAlmCabeceraPalletsCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Put(int id, UpdateAlmCabeceraPalletsCommand command)
        {
            if (id != command.IdAlmCabeceraPallets)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteAlmCabeceraPalletsCommand { IdAlmCabeceraPallets = id }));
        }
    }
}
