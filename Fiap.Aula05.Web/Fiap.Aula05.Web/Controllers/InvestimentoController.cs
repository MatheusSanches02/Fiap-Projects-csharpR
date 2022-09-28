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
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Investimento investimento)
        {
            return View();
        }
    }
}
