using Fiap.Aula05.Web.Models;
using Fiap.Aula05.Web.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula05.Web.Controllers
{
    public class CorretoraController : Controller
    {
        private DimDimContext _context;

        public CorretoraController(DimDimContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Corretora corretora)
        {
            _context.Corretoras.Add(corretora);
            _context.SaveChanges();
            TempData["msg"] = "Corretora cadastrada!";
            return RedirectToAction("Cadastrar");
        }

    }
}
