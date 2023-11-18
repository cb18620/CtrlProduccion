using Aplicacion.Features.Aplicacion.Parametricas.Queries;
using Aplicacion.Features.Empresa.Commands;
using Aplicacion.Features.Transporte.Commands;
using Aplicacion.Features.Transporte.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Webapi.Controllers.v1;

namespace WebApi.Controllers.v1.Transporte
{
    [ApiVersion("1.0")]
    [Authorize]
    public class TransporteController : BaseApiController
    {
        [HttpGet("GetTransporte")]
        public async Task<IActionResult> GetAllTransporte()
        {
            return Ok(await Mediator.Send(new GetAllTransporteQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateTransporteCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Put(int id, UpdateTransporteCommand command)
        {
            if (id != command.IdinsTransporte)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteTransporteCommand { IdinsTransporte = id }));



        }
    }
}
