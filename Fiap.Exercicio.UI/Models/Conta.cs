using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio.UI.Models
{
    internal abstract class Conta
    {
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public decimal Saldo { get; protected set; }
        public DateTime DataAbertura { get; set; }
        public IList<Cliente> Clientes { get; set; }

        internal Conta(int agencia, int numero, IList<Cliente> clientes)
        {
            Agencia = agencia;
            Numero = numero;
            Clientes = clientes;
        }

        public override string ToString()
        {
            return $"Número: {Numero}, Agência: {Agencia}, Saldo: {Saldo}";
        }
        public virtual void Depositar(decimal valor)
        {
            Saldo += valor;
        }
        public abstract void Retirar(decimal valor);
    }
}
