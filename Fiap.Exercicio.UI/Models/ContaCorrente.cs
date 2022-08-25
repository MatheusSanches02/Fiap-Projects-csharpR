using Fiap.Exercicio.UI.Exceptions;
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

            switch (tipo)
            {
                case TipoConta.Especial:
                    Limite = 500;
                    break;
                case TipoConta.Premium:
                    Limite = 1000;
                    break;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"Limite: {Limite}, Tipo Conta: {Tipo}";
        }

        public override void Retirar(decimal valor)
        {

            var saldoTotal = Saldo + Limite;
            if(valor > saldoTotal)
            {
                throw new SaldoInsuficienteException($"Valor disponivel {saldoTotal}");
            }
            Saldo -= valor;
        }
    }

    public enum TipoConta
    {
        Comum, Especial, Premium
    }
}
