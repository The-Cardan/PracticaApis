
using Microsoft.AspNetCore.Mvc;

namespace PracticaApis.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PropinaController : ControllerBase
    {
        [HttpGet("calcular")]
        public IActionResult Calcular(double monto, double porcentaje)
        {
            double propina = monto * porcentaje / 100;

            double totalPagar = monto + propina;

            return Ok(new
            {
                montoOriginal = monto,
                porcentajePropina = porcentaje,
                propina = Math.Round(propina, 2),
                totalPagar = Math.Round(totalPagar, 2)
            });
        }
    }
}
