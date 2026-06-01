using Microsoft.AspNetCore.Mvc;

namespace PracticaApis.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TextoController : ControllerBase
    {
        [HttpGet("contar")]
        public IActionResult Contar(string texto)
        {
            int caracteres = texto.Length;
            int palabras = texto.Split(' ').Length;

            texto = texto.ToLower();

            int vocales = 0;

            foreach (char letra in texto)
            {
                if (letra == 'a' ||
                    letra == 'e' ||
                    letra == 'i' ||
                    letra == 'o' ||
                    letra == 'u')
                {
                    vocales++;
                }
            }

            return Ok(new
            {
                texto = texto,
                caracteres = caracteres,
                palabras = palabras,
                vocales = vocales
            });
        }
    }
}
