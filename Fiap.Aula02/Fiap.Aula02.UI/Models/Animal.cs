

namespace Fiap.Aula02.UI.Models
{
    //Classe abstrata
    //Não pode ser instanciada
    //Pode conter métodos abstratos
    internal abstract class Animal
    {
        //Propriedades (Getters e Setters)
        public string Nome { get; set; }
        //prop -> tab tab
        public float Peso { get; set; }
        public int Idade { get; set; }
        public bool Selvagem { get; set; }

        //Construtores
        public Animal(string nome)
        {
            Nome = nome;
        }

        //Métodos
        public void Comer()
        {
            //cw -> tab tab
            Console.WriteLine("Comendo..");
        }

        public abstract void Andar();

        //Sobrecarga de método
        //Virtual -> permite a sobrescrita do método na classe filha
        public virtual void Comer(string alimento)
        {
            //Validar se a string é nula ou vazia
            if (string.IsNullOrEmpty(alimento))
            {
                //Se for, lançar uma exception
                throw new ArgumentException("Alimento inválido");
            }
            Console.WriteLine($"Comendo o {alimento}");
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Peso: {Peso}, " 
                + (Selvagem?"Selvagem":"Doméstico");
        }

    }
}
