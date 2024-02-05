using Aplicacion.Features.Despacho;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Webapi.Controllers.v1;

namespace WebApi.Controllers.v1.Despacho
{
    [ApiVersion("1.0")]
    public class DespachoController : BaseApiController
    {
        [HttpGet("Solicitud")]
        [Authorize]
        public async Task<IActionResult> Getsolicitud()
        {
            return Ok(await Mediator.Send(new GetAllVsolicitudescomercialQuery()));
        }
        [HttpGet("SolicitudDes")]
        [Authorize]
        public async Task<IActionResult> GetsolicitudDes()
        {
            return Ok(await Mediator.Send(new GetAllVsolicitudescomercialPQuery()));
        }
    }
}
