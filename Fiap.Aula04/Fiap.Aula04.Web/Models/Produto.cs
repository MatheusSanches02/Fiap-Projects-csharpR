namespace Fiap.Aula04.Web.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public DateTime DataFabricacao { get; set; }
        public decimal Preco { get; set; }
        public Estado Estado { get; set; }
        //Eletronico, Cama mesa e banho, telefonia..
        public string? Categoria { get; set; }
        public bool Disponivel { get; set; }
    }

    public enum Estado
    {
        Novo, Usado, Recondicionado
    }
}
