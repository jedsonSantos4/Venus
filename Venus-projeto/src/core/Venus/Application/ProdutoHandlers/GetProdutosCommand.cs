using Domain.Model;
using MediatR;

namespace Application.ProdutoHandlers
{
    public class GetProdutosCommand : IRequest<IEnumerable<Produto>>
    {

    }
}
