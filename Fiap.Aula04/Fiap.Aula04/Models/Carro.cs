using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Fiap.Aula04.Models
{
    public class Carro
    {
        [HiddenInput]
        public int Codigo { get; set; }
        public string? Modelo { get; set; }
        public string? Fabricante { get; set; }
        public int Ano { get; set; }

        [Display(Name = "Automático")]
        public bool Automatico { get; set; }
        public decimal Valor { get; set; }
        [Display(Name = "Combustível")]
        public Combustivel? Combustivel { get; set; }
    }

    public enum Combustivel
    {
        Etanol, Gasolina, Flex, [Display(Name ="Elétrico")]Eletrico
    }
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
              .GetMember(enumValue.ToString())
              .First()
              .GetCustomAttribute<DisplayAttribute>()
              ?.GetName();
        }
    }
}
