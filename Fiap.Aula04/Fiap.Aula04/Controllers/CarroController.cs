using Fiap.Aula04.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fiap.Aula04.Controllers
{
    public class CarroController : Controller
    {
        //Lista estática para armazenar carros
        private static List<Carro> _carroList = new List<Carro>();
        //Contador estático para definir o código do veiculo
        private static int _id = 0;

        public IActionResult Index()
        {
            //ViewBag.lista = _carroList;
            return View(_carroList);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            var fabricantes = new List<string>(new string[] {"Nissan", "Honda", "Fiat", "Toyota", "Renault", "Volkswagen"});

            ViewBag.Fabricantes = new SelectList(fabricantes);
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Carro carro)
        {
            carro.Codigo = ++_id;
            _carroList.Add(carro);
            TempData["mensagemSucesso"] = "Carro cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var carro = _carroList.Find(match => match.Codigo == id);

            return View(carro);
        }
    }
}
