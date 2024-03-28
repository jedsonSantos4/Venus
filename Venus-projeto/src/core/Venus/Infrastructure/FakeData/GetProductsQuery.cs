using Domain.Model;
using MediatR;

namespace Infrastructure.FakeData
{
    public record GetProductsQuery() : IRequest<IEnumerable<Produto>>;
}
