using Fiap.Aula04.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula04.Controllers
{
    public class CarroController : Controller
    {

        private static List<Carro> _carroList = new List<Carro>();

        public IActionResult Index()
        {
            ViewBag.lista = _carroList;
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Carro carro)
        {
            _carroList.Add(carro);
            ViewBag.mensagemSucesso = "Carro cadastrado!";
            return View();
        }
    }
}
