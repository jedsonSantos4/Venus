using Domain.Model;
using Infrastructure.FakeData;
using MediatR;

namespace Application.ProdutoHandlers
{
    public class GetProdutoHadler : IRequestHandler<GetProdutosCommand, IEnumerable<Produto>>
    {
        private readonly FakeDataStore _fakeDataStore;
        public GetProdutoHadler(FakeDataStore fakeDataStore) 
        {
            _fakeDataStore = fakeDataStore;
        } 
        public async Task<IEnumerable<Produto>> Handle(GetProdutosCommand request, CancellationToken cancellationToken)
        {
            var teste = await _fakeDataStore.GetAllProducts();
            return await _fakeDataStore.GetAllProducts();
        }
        
    }
}
