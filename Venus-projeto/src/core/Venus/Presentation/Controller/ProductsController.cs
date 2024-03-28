using Application.ProdutoHandlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controller
{
    [ApiController]
    [Route("api/produtos")]
    public class ProductsController : ControllerBase
    {
        
        private readonly IMediator _mediator;
        public ProductsController( IMediator mediator)
        {        
            _mediator = mediator;
        }
        [HttpGet("produtos")]
        public async Task<ActionResult> GetProducts()
        {
            try
            {
                var products = await _mediator.Send(new GetProdutosCommand());
                return Ok(products);
            }
            catch (Exception ex)
            {

                throw;
            }
           

            
        }
    }
}
