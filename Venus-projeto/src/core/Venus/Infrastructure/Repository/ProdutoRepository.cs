using Dapper;
using Infrastructure.Entity;
using Infrastructure.Interface;

namespace Infrastructure.Repository
{
    public class ProdutoRepository : IProdutoInfra
    {
        private readonly DbSession _db;
        public ProdutoRepository(DbSession db)
        {
            _db = db;
        }
        public async  Task<int> DeleteAsync(string id)
        {
            using (var conn = _db.Connection)
            {
                string query = "DELETE FROM produto WHERE Id = @id";
                var result = await conn.ExecuteAsync(sql: query,param: new {id});                
                return result;
            }
            
        }

        public async Task<IEnumerable<ProdutoEntity>> GeAll()
        {
            using ( var conn = _db.Connection)
            {
                string query = "SELECT * FROM produto";
                var produtos = (await conn.QueryAsync<ProdutoEntity>(sql:query)).ToList();
                return produtos;
            }            
        }

        public async Task<ProdutoEntity> Get(string id)
        {
            using (var conn = _db.Connection)
            {
                string query = "SELECT * FROM produto WHERE Id = @id";
                var produto = await conn.QueryFirstOrDefault(sql: query, param: new { id });
                return produto;
            }
        }

        public async Task GetCountRegistros ()
        {
            using (var conn = _db.Connection)
            {
                string query = @"SELECT * FROM produto 
                                 SELECT COUNT(*) FROM  produto";

                var reader = await conn.QueryMultipleAsync(sql:query);

                var teste = new  { 
                Contador = (await reader.ReadAsync<int>()).FirstOrDefault(),
                Produtos = (await reader.ReadAsync<ProdutoEntity>()).FirstOrDefault(),
                };
                
            }
        }

        public async Task<int> InsertAsync(ProdutoEntity obj)
        {
            using (var conn = _db.Connection)
            {
                string command = @"INSERT INTO produto (CodigoProduto,Nome,
                                                      Descricao,DataEntrada,DataSaida,
                                                      QuantidadeEntrada,QuantidadeSaida,Defeito)
                                        VALUES      (@CodigoProduto,@Nome,
                                                      @Descricao,@DataEntrada,@DataSaida,
                                                      @QuantidadeEntrada,@QuantidadeSaida,@Defeito)";
                
                var result = await conn.ExecuteAsync(sql: command, param: new { obj });
                return result;
            }
            
        }

        public async Task<int> UpdateAsync(ProdutoEntity obj)
        {
            using (var conn = _db.Connection)
            {
                string command = @"UPDATE produto SET Nome =@Nome,Descricao =@Descricao
                                    WHERE Id = @Id";

                var result = await conn.ExecuteAsync(sql: command, param: new { obj });
                return result;
            }
        }
    }
}
