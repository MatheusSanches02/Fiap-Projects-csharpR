using System.ComponentModel.DataAnnotations;

namespace Fiap.Aula04.Models
{
    public class Carro
    {
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
        Etanol, Gasolina, Flex, Eletrico
    }
}
