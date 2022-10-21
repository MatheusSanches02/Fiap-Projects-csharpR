using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula03.Web.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] //Abrir a página com o formulário
        public IActionResult Somar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Somar(int n1, int n2)
        {
            //Somar e mandar o resultado para a view
            var soma = n1 + n2;
            TempData["resultado"] = soma;
            return RedirectToAction("Somar");
        }
    }
}
