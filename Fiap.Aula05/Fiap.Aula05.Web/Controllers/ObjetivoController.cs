using Fiap.Aula05.Web.Models;
using Fiap.Aula05.Web.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula05.Web.Controllers
{
	public class ObjetivoController : Controller
	{
		private DimDimContext _context;

		//Injeção de dependência no construtor
		public ObjetivoController(DimDimContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
            ViewBag.objetivos = _context.Objetivos.ToList();
            return View();
        }

		[HttpPost]
		public IActionResult Cadastrar(Objetivo objetivo)
		{
			_context.Objetivos.Add(objetivo);
			_context.SaveChanges();
            TempData["msg"] = "Objetivo registrado!";
            return RedirectToAction("Index");
		}
	}
}
