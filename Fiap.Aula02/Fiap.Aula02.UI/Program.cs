using Fiap.Aula02.UI.Exceptions;
using Fiap.Aula02.UI.Models;

//Instanciar um Animal
//ALT + Enter ou CTRL + .
Animal tigre = new Tartaruga("José");

//Atribuir um nome para o animal
//tigre.Nome = "José";

//Exibir o nome do animal
Console.WriteLine(tigre.Nome);

//Instanciar um animal iniciando algumas propriedades
Animal cavalo = new Tartaruga("Alipio")
{
    //Nome = "Alipio",
    Peso = 200
};

//Exibir os valores do cavalo
Console.WriteLine(cavalo.Nome);

//Instanciar um elefante
//Chamada do construtor com os parâmetros na ordem do construtor
Elefante dumbo = new Elefante("Dumbo", "Africa", false);

//Chamada do construtor passando o nome e valor dos parâmetros
Elefante branco =
    new Elefante(origem: "Ásia", presa: true, nome: "Elefante Branco");

//Fazer o elefante comer
dumbo.Comer("Alface");

//Instanciar uma tartaruga com nome e tipo
var tartaruga = new Tartaruga("Leonardo", TipoTartagura.Carnivora);

try
{
    //Fazer a tartaruga comer 
    tartaruga.Comer();
    tartaruga.Comer("Teste");

    Animal rafael = new Tartaruga("");
    rafael.Comer("canudinho"); //chama o método do animal ou da tartaruga? Tartaruga
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}
catch (CanudinhoException)
{
    Console.WriteLine("Não pode comer canudinho");
}

//Fazer a tartaruga nadar 
tartaruga.Nadar();

//Exibir a profundidade máxima possível da tartaruga
Console.WriteLine($"Profundidade máxima: {tartaruga.CalcularProfundidadeMaxima()}");

//Exibir os dados da tartaruga
Console.WriteLine(tartaruga);

//Criar uma lista Elefantes (manada)
var manada = new List<Elefante>();

//Adicionar 3 elefantes na lista
manada.Add(new Elefante("Josue", "Africa", true));
manada.Add(new Elefante("Pedrao", "Asia", false));
manada.Add(new Elefante("Maria", "Asia", true));

//Exibir os dados dos elefantes
foreach (var churros in manada)
{
    Console.WriteLine(churros);
}