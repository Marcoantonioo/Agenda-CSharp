using AgendaProj.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace AgendaProj.Controllers
{
    public class AgendaController : Controller
    {
        private readonly IAgendaRepository _repository;
        public AgendaController(IAgendaRepository repository){
            _repository = repository;
        }
        public IActionResult Index(){
            var agenda = _repository.GetAll().OrderByDescending(x => x.data);
            return View(agenda);
        }
        [HttpGet]
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(Agenda agenda)
        {
            _repository.Create(agenda);

            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            return View(_repository.GetById(id));
        }
        [HttpPost]
        public IActionResult Edit(Agenda agenda)
        {
            _repository.Update(agenda);
            return RedirectToAction("Index");
        }
    }
}