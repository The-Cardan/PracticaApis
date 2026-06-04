using Microsoft.AspNetCore.Mvc;

namespace PracticaApis.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class FechasController : ControllerBase
    {
        [HttpGet("diferencia")]
        public IActionResult Diferencia(DateTime desde, DateTime hasta)
        {
            TimeSpan diferencia = hasta - desde;

            return Ok(new
            {
                desde = desde.ToString("yyyy-MM-dd"),
                hasta = hasta.ToString("yyyy-MM-dd"),
                diasDiferencia = (int)diferencia.TotalDays
            });
        }
    }
}
