using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio.UI.Models
{
    internal class Cliente
    {
        public long Id { get; set; }
        public string Nome { get; set; }

        public string Cpf { get; set; }

        internal Cliente(long id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}";
        }
    }
}
