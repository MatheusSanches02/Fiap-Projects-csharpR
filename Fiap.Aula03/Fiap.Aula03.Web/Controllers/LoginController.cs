using Fiap.Aula03.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula03.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] //Abrir a página com o formulário
        public IActionResult Logar()
        {
            return View();
        }

        [HttpPost] //Receber os parâmetros do formulário
        public IActionResult Logar(Login login)
        {
            //Enviar o usuário para a view
            ViewData["churros"] = login.Usuario;
            ViewBag.abacate = login;

            return View("Logado", login); //Logado.cshtml com o objeto Login
            //return Content($"Usuário: {login.Usuario}, Senha: {login.Senha}");
        }

    }
}
