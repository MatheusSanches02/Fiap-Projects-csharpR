using Fiap.Aula04.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula04.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Produto produto)
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Editar(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Editar(Produto produto)
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Excluir(int id)
        {
            return View();
        }
    }
}
