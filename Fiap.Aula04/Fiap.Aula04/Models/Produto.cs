using System.ComponentModel.DataAnnotations;

namespace Fiap.Aula04.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        [Display(Name="Data de Fabricação")]
        public DateTime DataFabricacao { get; set; }
        [Display(Name="Preço")]
        public decimal Preco { get; set; }
        public Estado Estado { get; set; }
        public string? Categoria { get; set; }
        [Display(Name="Disponível")]
        public bool Disponivel { get; set; }
    }

    public enum Estado
    {
        Novo, Usado, Recondicionado
    }
}
