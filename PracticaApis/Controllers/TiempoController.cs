using Microsoft.AspNetCore.Mvc;

namespace Practica1WebServices.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TiempoController : ControllerBase
    {
        [HttpGet("formatear")]
        public IActionResult Formatear(int segundos)
        {
            int horas = segundos / 3600;

            int resto = segundos % 3600;

            int minutos = resto / 60;

            int segundosRestantes = resto % 60;

            string formato = $"{horas:D2}:{minutos:D2}:{segundosRestantes:D2}";

            return Ok(new
            {
                segundosOriginales = segundos,
                horas = horas,
                minutos = minutos,
                segundos = segundosRestantes,
                formato = formato
            });
        }
    }
}