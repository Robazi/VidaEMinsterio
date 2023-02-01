using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VidaEMinsterio.Models;

namespace VidaEMinsterio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipanteController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<ParticipanteModel>> BucasTodosParticipantes()
        {
            return Ok();
        }
    }
}
