using AppService;
using Core;
using Microsoft.AspNetCore.Mvc;

namespace Anonimizador.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnonimizeController : Controller
    {
        private readonly AnonimizeService _service;

        public AnonimizeController()
        {
            _service = new AnonimizeService();
        }

        [HttpPost]
        public IActionResult Anonimize(AnonimizeRequest request)
        {
            var result = _service.Anonimize(request);

            if (result)
                return Ok();
            else
                return NoContent();
        }
    }
}
