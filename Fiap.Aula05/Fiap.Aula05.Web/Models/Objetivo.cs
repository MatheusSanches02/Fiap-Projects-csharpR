namespace Fiap.Aula05.Web.Models
{
    public class Objetivo
    {
        public int ObjetivoId { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }

        public IList<InvestimentoObjetivo> InvestimentosObjetivos { get; set; }
    }
}
