using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula._03.Web.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Soma()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Soma(decimal numero1, decimal numero2)
        {
            ViewBag.soma = numero1 + numero2;
            return View("SomaFeita");
        }
    }
}
