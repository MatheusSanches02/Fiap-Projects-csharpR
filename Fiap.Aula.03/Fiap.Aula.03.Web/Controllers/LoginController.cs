using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula._03.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Logar() 
        { 
            return View(); 
        } 
    }
}
