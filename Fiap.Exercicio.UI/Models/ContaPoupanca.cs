using Fiap.Exercicio.UI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio.UI.Models
{
    internal class ContaPoupanca : Conta, IContaInvestimento
    {
        public decimal Taxa { get; set; }

        public ContaPoupanca(int agencia, int numero, IList<Cliente> clientes, decimal taxa) : base(agencia, numero, clientes)
        {
            Taxa = taxa;
        }

        public override void Retirar(decimal valor)
        {
            var total = valor + Taxa;
            if(total > Saldo)
            {
                throw new SaldoInsuficienteException($"Valor disponivel para saque: {Saldo - Taxa}");
            }
            Saldo -= total;
        }

        public decimal CalcularRetornoInvestimento()
        {
            return Saldo * 0.04m;
        }
    }
}
