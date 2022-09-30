using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula05.Web.Models
{
    public class StatusInvestimento
    {
        [HiddenInput]
        public int StatusInvestimentoId { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public Status Status { get; set; }
    }

    public enum Status
    {
        Cancelado, Ativo, Liquidado, EmAndamento
    }
}
