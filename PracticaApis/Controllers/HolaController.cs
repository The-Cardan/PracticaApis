using Microsoft.AspNetCore.Mvc;
namespace PracticaApis.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HolaController : ControllerBase
    {
        [HttpGet("saludo")]
        public IActionResult Saludo(string nombre)
        {
            return Ok(new
            {
                mensaje = $"Bienvenido {nombre}"
            });
        }
    }
}
