using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Aula05.Web.Models
{
    [Table("Tbl_Investimento")]
    public class Investimento
    {
        [HiddenInput, Column("Id")]
        public int InvestimentoId { get; set; }
        [Required, MaxLength(100)]
        public string? Nome { get; set; }        
        public decimal Rendimento { get; set; }
        [Display(Name = "Capital Investido"), Required]
        public decimal CapitalInvestido { get; set; }
        [Column("TipoInvestimento")]
        public TipoInvestimento Tipo { get; set; }
        public DateTime Data { get; set; }

        //Relacionamento 1:1
        public StatusInvestimento StatusInvestimento { get; set; }
        public int StatusInvestimentoId { get; set; } //FK

        //Relacionamento N:1
        public Corretora Corretora { get; set; }
        public int CorretoraId { get; set; }

        //Relacionamento N:M
        public IList<InvestimentoObjetivo> InvestimentosObjetivos { get; set; }
    }

    public enum TipoInvestimento
    {
        Imovel, Cdb, Tesouro, Poupanca
    }
}
