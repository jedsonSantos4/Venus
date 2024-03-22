using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controller
{
    public class FuncionarioController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
