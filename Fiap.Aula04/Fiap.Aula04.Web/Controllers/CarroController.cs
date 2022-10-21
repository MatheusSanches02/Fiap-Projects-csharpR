using Fiap.Aula04.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fiap.Aula04.Web.Controllers
{
    public class CarroController : Controller
    {
        //Lista estática para armazenar os carros
        private static List<Carro> _lista = new List<Carro>();
        //Contador estático para definir o código do Veiculo
        private static int _id = 0;

        [HttpPost]
        public IActionResult Remover(int churros)
        {
            //Pesquisar a posição do carro pelo código
            var index = _lista.FindIndex(c => c.Codigo == churros);
            //Remover o carro pela posição da lista
            _lista.RemoveAt(index);
            //Mensagem de sucesso
            TempData["msg"] = "Carro removido!";
            //Redirecionar para a listagem
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(Carro carro)
        {
            //Pesquisa a posição do carro pelo código
            var index = _lista.FindIndex(c => c.Codigo == carro.Codigo);
            //Atualizar o carro na lista
            _lista[index] = carro;
            //Mensagem de sucesso
            TempData["msg"] = "Carro atualizado!";
            //Redirecionar para a listagem
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            CarregarFabricantes();
            //Pesquisar o carro pelo código
            var carro = _lista.Find(match => match.Codigo == id);
            //Enviar o carro para a view
            return View(carro);
        }

        public IActionResult Index()
        {
            //Ajustar o Index para exibir todos os carros da lista
            //em uma tabela HTML
            //Enviar a lista de carro para a view
            //ViewBag.acai = _lista;
            //Criar a view e a tabela HTML com os dados
            return View(_lista);
        }

        [HttpGet] //Retorna a view com o formulário
        public IActionResult Cadastrar()
        {
            CarregarFabricantes();
            return View();
        }

        private void CarregarFabricantes()
        {
            //Criar uma lista de string com fabricantes
            var lista = new List<string>(new string[] {"Nissan", "FIAT",
                "Honda", "Toyota", "Caoa", "Ford", "Volkswagen"});
            //Enviar o SelectList para a view criar as options do select
            ViewBag.Fabricantes = new SelectList(lista);
        }

        [HttpPost] //Receber os valores do formulário HTML
        public IActionResult Cadastrar(Carro carro)
        {
            //Setar o ID do carro
            carro.Codigo = ++_id;
            //Adicionar o carro na lista
            _lista.Add(carro);
            //Exibir uma mensagem de sucesso para a view
            TempData["churros"] = "Carro cadastrado!";
            //Redirect para uma action (Método)
            return RedirectToAction("Cadastrar"); //Método
        }
    }
}
