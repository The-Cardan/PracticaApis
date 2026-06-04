using Microsoft.AspNetCore.Mvc;
using Practica1WebServices.Models;

namespace PracticaApis.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class NotasController : ControllerBase
    {
        [HttpPost("estadisticas")]
        public IActionResult Estadisticas(NotasRequest request)
        {
            double promedio = request.Notas.Average();

            int notaMayor = request.Notas.Max();

            int notaMenor = request.Notas.Min();

            int aprobados = request.Notas.Count(n => n >= 70);

            int reprobados = request.Notas.Count(n => n < 70);

            return Ok(new
            {
                promedio = Math.Round(promedio, 2),
                notaMayor = notaMayor,
                notaMenor = notaMenor,
                aprobados = aprobados,
                reprobados = reprobados
            });
        }
    }

}
