namespace Fiap.Aula05.Web.Models
{
    public class Corretora
    {
        public int CorretoraId { get; set; }
        public string? Nome { get; set; }

        //Relacionamento 1:N
        public List<Investimento> Investimentos { get; set; }
    }
}
