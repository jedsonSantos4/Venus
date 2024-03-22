namespace Infrastructure.Entity
{
    public class ProdutoEntity : BaseEntity
    {
        public int CodigoProduto { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public int QuantidadeEntrada { get; set; }
        public int QuantidadeSaida { get; set; }
        public int Defeito { get; set; }        
    }
}
