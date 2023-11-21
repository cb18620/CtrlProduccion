using Aplicacion.Features.Almacen.Commands;
using Aplicacion.Features.Almacen.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Webapi.Controllers.v1;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebApi.Controllers.Almacen
{
    [ApiVersion("1.0")]
    public class AlmCabeceraConPalletsController : BaseApiController
    {

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Post(CreateAlmContenidoPalletsCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

    }
}
