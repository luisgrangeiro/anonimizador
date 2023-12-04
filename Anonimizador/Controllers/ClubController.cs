using AppService;
using Core;
using Microsoft.AspNetCore.Mvc;

namespace Anonimizador.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClubController : Controller
    {
        private readonly AnonimizeService _service;

        public ClubController()
        {
            _service = new AnonimizeService();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetClubRegisters());
        }
    }
}
