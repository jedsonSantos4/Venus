namespace Domain.Model
{
    public class Produto : Base
    {        
        public string Descricao { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public int QuantidadeEntrada { get; set; }
        public int QuantidadeSaida { get; set; }
        public int Defeito { get; set; }
    }
}
