using Fiap.Aula._03.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula._03.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] //abrir página com formulário
        public IActionResult Logar() 
        { 
            return View(); 
        }

        [HttpPost]
        public IActionResult Logar(Usuario usuario)
        {
            ViewData["nome"] = usuario.Nome;
            ViewBag.usuario = usuario;

            return View("Logado");
        }
    }
}
