
namespace Fiap.Aula02.UI.Models
{
    internal class Elefante : Animal
    {
        //Propriedades
        public string Origem { get; set; }
        public bool Presa { get; set; }

        //Construtor com nome, origem e presa
        public Elefante(string nome, string origem, bool presa) : base(nome)
        {
            Origem = origem;
            Presa = presa;
        }

        //Métodos
        public override void Andar()
        {
            Console.WriteLine("Andando pesado...");
        }

    }
}
