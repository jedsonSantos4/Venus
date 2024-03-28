using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Fahrenheit/")]
      
        //[ProducesResponseType(typeof(Temperatura), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(FalhaCalculo), StatusCodes.Status400BadRequest)]
        public ActionResult<string> GetConversaoFahrenheit()
        {
            _logger.LogInformation(
                $"Recebida temperatura para conversao: ");

         
            return "";
        }
    }
}
