using Domain.Model;

namespace Infrastructure.FakeData
{
    public class FakeDataStore
    {
        private static List<Produto> _products;
        public FakeDataStore()
        {
            _products = new List<Produto>
        {
            new Produto { Id = 1, Nome = "Test Product 1" },
            new Produto { Id = 2, Nome = "Test Product 2" },
            new Produto { Id = 3, Nome = "Test Product 3" }
        };
        }
        public async Task AddProduct(Produto product)
        {
            _products.Add(product);
            await Task.CompletedTask;
        }
        public async Task<IEnumerable<Produto>> GetAllProducts() => await Task.FromResult(_products);
    }
}
