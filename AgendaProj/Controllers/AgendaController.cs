using AgendaProj.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace AgendaProj.Controllers
{
    public class AgendaController : Controller
    {
        private readonly IAgendaRepository _repositoryChamado;
        private readonly IClientRepository _repositoryClient;
        private readonly ISituacaoRepository _repositorySituacao;
        public AgendaController(IAgendaRepository chamadoRepository,
                                IClientRepository clientRepository,
                                ISituacaoRepository situacaoRepository){
           _repositoryChamado = chamadoRepository;
           _repositoryClient = clientRepository;
           _repositorySituacao = situacaoRepository;
        }
        public IActionResult Index(){
            var agenda = _repositoryChamado.GetAll().OrderByDescending(x => x.data);
            return View(agenda);
        }
        [HttpGet]
        public IActionResult Create(){
            ViewBag.cliente = _repositoryClient.GetAll();
            ViewBag.situacao = _repositorySituacao.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Agenda agenda)
        {
           _repositoryChamado.Create(agenda);

            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
           _repositoryChamado.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]   
        public IActionResult Edit(int id)
        {
            var agenda = _repositoryChamado.GetById(id);
            ViewBag.situacao = _repositorySituacao.GetAll();
            return View(agenda); 
        }
        [HttpPost]
        public IActionResult Edit(Agenda agenda)
        {
            _repositoryChamado.Update(agenda);
            return RedirectToAction("Index");
        }
    }
}