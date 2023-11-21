using Aplicacion.Features.Aplicacion.Clasificador.Queries;
using Aplicacion.Features.Clasificador.Commands;
using Aplicacion.Features.Clasificador.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Webapi.Controllers.v1;

namespace WebApi.Controllers.v1.Clasificador
{
    [ApiVersion("1.0")]
    [Authorize]
    public class ClasificadorController : BaseApiController
    {
        [HttpGet("Tipo")]
        public async Task<IActionResult> GetTipo()
        {
            return Ok(await Mediator.Send(new GetAllClasificadorTipoQuery()));
        }
        [HttpGet("Turno")]
        public async Task<IActionResult> GetTurno()
        {
            return Ok(await Mediator.Send(new GetAllClasificadorTurnoQuery()));
        }
        [HttpGet("Linea")]
        public async Task<IActionResult> GetLinea()
        {
            return Ok(await Mediator.Send(new GetAllClasificadorLineaQuery()));
        }
        [HttpGet("Producto")]
        public async Task<IActionResult> GetProducto()
        {
            return Ok(await Mediator.Send(new GetAllClasificadorproductoQuery()));
        }
        [HttpGet("ColorEnvase")]
        public async Task<IActionResult> GetColorEnvase()
        {
            return Ok(await Mediator.Send(new GetAllClasificadorColorProdQuery()));
        }
        [HttpGet("TipoEmpresa")]
        public async Task<IActionResult> GetlistadoTipoEmpresa()
        {
            return Ok(await Mediator.Send(new GetAllClasificadorEmpresaQuery()));
        }
        [HttpGet("GetAllGenClasificador")]
        [Authorize]
        public async Task<IActionResult> GetAllGenClasificador()
        {
            return Ok(await Mediator.Send(new GetAllGenClasificadorQuery()));
        }


        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Post(CreateGenClasificadorCommand command)
        {
            return Ok(await Mediator.Send(command));
        }


        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Put(int id, UpdateGenClasificadorCommand command)
        {
            if (id != command.IdgenClasificador)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }


        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteGenClasificadorCommand { IdgenClasificador = id }));
        }
    }
}
