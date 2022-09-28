using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Fiap.Aula05.Web.Models
{
    public class Investimento
    {
        [Key]
        public int Codigo { get; set; } //InvestimentoId
        public string? Titulo { get; set; }
        public string? Objetivo { get; set; }
        public decimal Rendimento { get; set; }
        public decimal CapitalInvestido { get; set; }
        public TipoInvestimento Tipo { get; set; }
        public DateTime Data { get; set; }
    }

    public enum TipoInvestimento
    {
        Imovel, 
        Cdb, 
        Tesouro,
        [Display(Name = "Poupança")]
        Poupanca
    }

    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<DisplayAttribute>()
                            .GetName();
        }
    }
}
