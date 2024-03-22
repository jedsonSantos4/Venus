using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controller
{
    public class ProdutoController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
