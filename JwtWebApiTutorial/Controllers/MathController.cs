using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtWebApiTutorial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class MathController : Controller
    {
        [HttpGet("sum")]
        public ActionResult<int> Sum(int a, int b)
        {
            // Se o código chegar aqui, o usuário está autenticado
            return Ok(a + b);
        }
    }
}
