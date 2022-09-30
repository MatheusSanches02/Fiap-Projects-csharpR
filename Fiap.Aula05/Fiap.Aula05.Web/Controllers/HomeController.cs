using Fiap.Aula05.Web.Models;
using Fiap.Aula05.Web.Persistencia;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fiap.Aula05.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DimDimContext _context;

        public HomeController(ILogger<HomeController> logger, DimDimContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.total = _context.Investimentos.Count();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}