using Fiap.Aula02.UI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula02.UI.Models
{
    internal class Tartaruga : Animal, IAquatico
    {
        //Propriedade 
        public TipoTartagura Tipo { get; set; }

        //Construtor
        public Tartaruga(string nome) : base(nome)
        {
            
        }

        //Construtor com nome e tipo
        public Tartaruga(string nome, TipoTartagura tipo) : base(nome)
        {
            Tipo = tipo;
        }

        //Métodos
        public override void Andar()
        {
            Console.WriteLine("Andando lento..");
        }

        //Sobrescrever o método comer(string alimento) do animal
        public override void Comer(string alimento)
        {
            //Se o alimento for canudo ou canudinho não comer
            if (alimento == "canudinho" || alimento == "canudo")
            {
                throw new CanudinhoException("Não pode comer");
            }
            else
            {   //Se não, chamar o método comer do pai
                base.Comer(alimento);
            }
        }

        public void Nadar()
        {
            Console.WriteLine("Tartaruga nadando..");
        }

        public int CalcularProfundidadeMaxima()
        {
            return 50;
        }

        //Sobrescrever o método ToString()
        public override string ToString()
        {
            return base.ToString() + $" Tipo: {Tipo}";
        }

    }

    //Enum: Conjunto de constantes, pode ser criado em um arquivo separado
    public enum TipoTartagura
    {
        Herbivora, Onivora, Carnivora, 
    }

}
