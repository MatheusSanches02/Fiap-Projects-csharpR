//Ler a quantidade de clientes
using Fiap.Exercicio.Exceptions;
using Fiap.Exercicio.Models;

Console.WriteLine("Digite a qtd de clientes");
int qtd = Convert.ToInt32(Console.ReadLine());

//Criar uma lista de clientes
IList<Cliente> lista = new List<Cliente>();

//Criar um laço para ler os clientes
for (int i = 0; i < qtd; i++)
{
    //Ler os dados do cliente (id e nome)
    Console.WriteLine("Digite o Id");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o nome");
    string? nome = Console.ReadLine();
    //Instanciar o cliente e adicionar na lista
    Cliente cliente = new Cliente(id, nome);
    lista.Add(cliente);
}

//Ler os dados da conta corrente (numero, agencia e tipo) 
Console.WriteLine("Digite o número");
var numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a agencia");
var agencia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o tipo da conta 0-Comum, 1-Especial, 2-Premium");
TipoConta tipo = (TipoConta)Convert.ToInt32(Console.ReadLine());

//Instanciar a conta corrente
var cc = new ContaCorrente(agencia, numero, lista, tipo);

//Exibir os dados da conta corrente
foreach (Cliente cliente in cc.Clientes)
{
    Console.WriteLine(cliente);
}
Console.WriteLine(cc);

//Exibir o menu (1-depositar, 2-retirar, 3-exibir dados, 0-sair)
int opcao;
do
{
    Console.WriteLine("Escolha uma opção: 1-depositar, 2-retirar, 3-exibir dados, 0-sair");
    opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.WriteLine("Digite o valor para depósito");
            decimal valor = Convert.ToDecimal(Console.ReadLine());
            cc.Depositar(valor);
            Console.WriteLine("Depósito realizado");
            break;
        case 2:
            Console.WriteLine("Digite o valor para retirada");
            valor = Convert.ToDecimal(Console.ReadLine());
            try
            {
                cc.Retirar(valor);
                Console.WriteLine("Saque realizado");
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
            }
            break;
        case 3:
            Console.WriteLine(cc);
            break;
        case 0:
            Console.WriteLine("Adeus");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
} while (opcao != 0);
