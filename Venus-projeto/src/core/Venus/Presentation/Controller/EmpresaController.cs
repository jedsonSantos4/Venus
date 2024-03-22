using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controller
{
    public class EmpresaController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
