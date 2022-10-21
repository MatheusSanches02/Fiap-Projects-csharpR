using Fiap.Aula05.Web.Models;
using Fiap.Aula05.Web.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula05.Web.Controllers
{
    public class ObjetivoController : Controller
    {
        private DimDimContext _context;

        public ObjetivoController(DimDimContext context)
        {
            _context = context;
        }

        public IActionResult Cadastrar(Objetivo objetivo)
        {
            //Cadastrar
            _context.Objetivos.Add(objetivo);
            _context.SaveChanges();
            //Mensagem
            TempData["msg"] = "Objetivo registrado!";
            //Redirect para Index
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            ViewBag.objetivos = _context.Objetivos.ToList();
            return View();
        }
    }
}
