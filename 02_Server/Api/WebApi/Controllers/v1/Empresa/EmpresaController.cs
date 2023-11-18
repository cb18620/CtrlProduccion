using Aplicacion.Features.Aplicacion.Parametricas.Commands;
using Aplicacion.Features.Aplicacion.Parametricas.Queries;
using Aplicacion.Features.Empresa.Commands;
using Aplicacion.Features.Empresa.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Webapi.Controllers.v1;

namespace WebApi.Controllers.v1.Empresa
{
    [ApiVersion("1.0")]
    [Authorize]
    public class EmpresaController : BaseApiController
    {
        [HttpGet("Empresa")]
        public async Task<IActionResult> GetAllPersona()
        {
            return Ok(await Mediator.Send(new GetAllInsEmpresaQuery()));
        }


        [HttpPost]
        public async Task<IActionResult> Post(CreateEmpresaCommand command)
        {
            return Ok(await Mediator.Send(command));
        }


        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Put(int id, UpdateEmpresaCommand command)
        {
            if (id != command.IdinsEmpresa)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }


        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteEmpresaCommand { IdinsEmpresa = id }));



        }
    }
}
