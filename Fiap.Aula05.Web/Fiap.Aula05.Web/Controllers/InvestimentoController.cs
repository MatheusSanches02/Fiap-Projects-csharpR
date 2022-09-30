using Fiap.Aula05.Web.Models;
using Fiap.Aula05.Web.Models.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Aula05.Web.Controllers
{
    public class InvestimentoController : Controller
    {
        private DimDimContext _context;
        public InvestimentoController(DimDimContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var lista = _context.Investimentos.ToList();

            return View(lista);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Investimento investimento)
        {
            _context.Investimentos.Add(investimento);
			_context.SaveChanges();

            TempData["msg"] = "Investimento Realizado!";
            return RedirectToAction("Cadastrar");
        }
        public IActionResult Editar(int id)
        {
            var investimento = _context.Investimentos.Find(id);

            return View(investimento);
        }

        [HttpPost]
        public IActionResult Editar(Investimento investimento)
        {
            _context.Investimentos.Update(investimento);
            _context.SaveChanges();

            TempData["msg"] = "Investimento Atualizado!";
            return RedirectToAction("Index");
        }
    }
}
