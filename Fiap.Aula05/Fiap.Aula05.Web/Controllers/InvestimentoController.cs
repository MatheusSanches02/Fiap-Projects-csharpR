using Fiap.Aula05.Web.Models;
using Fiap.Aula05.Web.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Aula05.Web.Controllers
{
    public class InvestimentoController : Controller
    {
        private DimDimContext _context;

        //Injeção de dependência no construtor
        public InvestimentoController(DimDimContext context)
        {
            _context = context;
        }

        //Método para adicionar um investimento objetivo (Associativa)
        [HttpPost]
        public IActionResult Adicionar(InvestimentoObjetivo associativa)
        {
            //Cadastrar
            _context.InvestimentosObjetivos.Add(associativa);
            _context.SaveChanges();
            //Mensagem
            TempData["msg"] = "Objetivo adicionado ao investimento!";
            //Redirect
            return RedirectToAction("Detalhar", new { id = associativa.InvestimentoId });
        }

        [HttpGet]
        public IActionResult Detalhar(int id)
        {
            //Enviar a lista de objetivos associados ao investimento
            //Pesqquisar por todos os objetivos associados ao investimento
            var investimentoObjetivos = _context.InvestimentosObjetivos
                .Where(i => i.InvestimentoId == id) //Filtra
                .Select(i => i.Objetivo) //Seleciona o retorno
                .ToList();
            //Enviar a lista de objetivos para a view
            ViewBag.investimentoObjetivos = investimentoObjetivos;
            //Enviar a lista de objetivos para o Select
            //Pesquisar por todos os objetivos
            var objetivos = _context.Objetivos.ToList();

            //Filtrar a lista de todos os objetivos, retirando os já associados
            var listaFiltrada = objetivos
                .Where(o => !investimentoObjetivos.Any(o1 => o1.ObjetivoId == o.ObjetivoId));

            //Enviar através da viewBag o selectList de objetivo
            ViewBag.objetivos = new SelectList(listaFiltrada, "ObjetivoId", "Titulo");
            //Pesquisar o investimento pelo ID
            var investimento = _context.Investimentos
                .Include(i => i.Corretora)
                .Include(i => i.StatusInvestimento)
                .Where(i => i.InvestimentoId == id)
                .FirstOrDefault();
            //Enviar o investimento para a view
            return View(investimento);
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            //Pesquisar o investimento pelo ID
            var investimento = _context.Investimentos.Find(id);
            //Remover o investimento
            _context.Investimentos.Remove(investimento);
            //Commit
            _context.SaveChanges();
            //Mensagem
            TempData["msg"] = "Investimento removido!";
            //Redirecionar para a listagem
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(Investimento investimento)
        {
            //Atualizar o investimento
            _context.Investimentos.Update(investimento);
            _context.SaveChanges();
            //Mensagem
            TempData["msg"] = "Investimento atualizado";
            //Redirect
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            CarregarCorretoras();
            //Pesquisar o investimento pelo codigo
            var investimento = _context.Investimentos
                .Include(i => i.StatusInvestimento)
                .Where(i => i.InvestimentoId == id)
                .FirstOrDefault();//recupera o primeiro resultado
            //Retornar a view com os dados do investimento
            return View(investimento);
        }

        [HttpGet]
        public IActionResult Index(string termoPesquisa)
        {
            //Recuperar a lista com todos os investimentos
            var lista = _context.Investimentos
                .Where(i => i.Nome.Contains(termoPesquisa) || termoPesquisa == null)
                .Include(i => i.StatusInvestimento)//Inclui o relacionamento no resultado da pesquisa
                .Include(i => i.Corretora)
                .ToList();
            //Retornar a view com a lista
            return View(lista);
        }

        [HttpPost]
        public IActionResult Cadastrar(Investimento investimento)
        {
            //Cadastrar no banco
            _context.Investimentos.Add(investimento);
            _context.SaveChanges();
            //Mensagem de sucesso
            TempData["msg"] = "Investimento realizado!";
            //Redirect
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            CarregarCorretoras();
            return View();
        }

        private void CarregarCorretoras()
        {
            //Enviar a lista de corretoras para as options do select
            //Pesquisar todas as corretoras
            var lista = _context.Corretoras.ToList();
            //Enviar um SelectList para a view
            ViewBag.corretoras = new SelectList(lista, "CorretoraId", "Nome");
        }
    }
}