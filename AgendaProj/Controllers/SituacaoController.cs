using AgendaProj.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgendaProj.Controllers
{
    public class SituacaoController : Controller
    {
         private readonly ISituacaoRepository _repository;
        public SituacaoController(ISituacaoRepository situacaoRepository){
            _repository = situacaoRepository;
    }
         public IActionResult Index(){
           var situacao = _repository.GetAll();
            return View(situacao); 
        }
         [HttpGet]
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(Situacao situacao)
        {
            _repository.Create(situacao);

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }
         public IActionResult Edit(int id)
        {
            var situacao = _repository.GetById(id);
            return View(situacao);
        }
        [HttpPost]
        public IActionResult Edit(Situacao situacao)
        {
            _repository.Update(situacao);
            return RedirectToAction("Index");
        }
        
    }
    
}