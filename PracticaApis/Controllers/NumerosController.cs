using Microsoft.AspNetCore.Mvc;
namespace PracticaApis.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NumerosController : ControllerBase
    {
        [HttpGet("analizar")]
        public IActionResult Analizar(int n)
        {
            // Par o impar
            bool esPar = n % 2 == 0;

            // Positivo, negativo o cero
            string tipo;

            if (n > 0)
            {
                tipo = "Positivo";
            }
            else if (n < 0)
            {
                tipo = "Negativo";
            }
            else
            {
                tipo = "Cero";
            }

            // Primo
            bool esPrimo = true;

            if (n <= 1)
            {
                esPrimo = false;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
            }

            return Ok(new
            {
                numero = n,
                esPar = esPar,
                esPrimo = esPrimo,
                tipo = tipo
            });
        }
    }
}

