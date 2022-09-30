namespace Fiap.Aula05.Web.Models
{
    //Mapeia a Tabela Associativa
    public class InvestimentoObjetivo
    {
        public Objetivo Objetivo { get; set; }
        public int ObjetivoId { get; set; }
        public Investimento Investimento { get; set; }
        public int InvestimentoId { get; set; }
    }
}
