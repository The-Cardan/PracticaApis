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



        [HttpGet("agregar")]
        public IActionResult Agregar(DateTime fecha, int dias)
        {
            DateTime nuevaFecha = fecha.AddDays(dias);

            return Ok(new
            {
                fechaOriginal = fecha.ToString("yyyy-MM-dd"),
                diasAgregados = dias,
                nuevaFecha = nuevaFecha.ToString("yyyy-MM-dd")
            });
        }
    }

}
