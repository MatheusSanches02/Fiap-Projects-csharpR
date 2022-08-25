
using Fiap.Exercicio.UI.Models;

Console.WriteLine("Digite a quantidade de clientes");
int qtd = Convert.ToInt32(Console.ReadLine());

var clientes = new List<Cliente>();

for (int i = 0; i < qtd; i++)
{
    Console.WriteLine("DIgite o ID");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("DIgite o Nome");
    string? nome = Console.ReadLine();

    var cliente = new Cliente(id, nome);
    clientes.Add(cliente);
}

Console.WriteLine("Digite o numero da conta");
var num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a agencia");
var agencia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o tipo da conta: 0-Comum, 1-Especial, 2-Premium");
TipoConta tipo = (TipoConta)Convert.ToInt32(Console.ReadLine());

var cc = new ContaCorrente(agencia, num, clientes, tipo);

foreach(Cliente cliente in cc.Clientes)
{
    Console.WriteLine(cliente);
}
Console.WriteLine(cc);

int opcao;
do
{
    Console.WriteLine("Escolha uma opção: 1-Depositar, 2-Retirar, 3-Exibir dados, 0-Sair");
    opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            try 
            {
                Console.WriteLine("Digite o valor para depósito");
                decimal valor = Convert.ToDecimal(Console.ReadLine());
                cc.Depositar(valor);
                Console.WriteLine("Depósito realizado");
            }
            catch(Exception e)
            {
                throw new Exception();
            }
            break;
        case 2:
            Console.WriteLine("Digite o valor para retirada");
            valor = Convert.ToDecimal(Console.ReadLine());
            cc.Retirar(valor);
            Console.WriteLine("Saque realizado");
            break;
        case 3:
            Console.WriteLine(cc);
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
} while (opcao != 0);
