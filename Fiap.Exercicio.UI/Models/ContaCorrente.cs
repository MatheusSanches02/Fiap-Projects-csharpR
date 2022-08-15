using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio.UI.Models
{
    internal class ContaCorrente : Conta
    {
        public TipoConta Tipo { get; set; }
        public decimal Limite { get; set; }

        public ContaCorrente(int agencia, int numero, IList<Cliente> clientes, TipoConta tipo) : base(agencia, numero, clientes)
        {
            Tipo = tipo;
        }

        public override void Depositar(decimal valor)
        {
            Saldo = Saldo + valor;
        }

        public override void Retirar(decimal valor)
        {
            Saldo = Saldo - valor;
        }
    }

    public enum TipoConta
    {
        Comum, Especial, Premium
    }
}
