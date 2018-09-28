using System.Linq;
using AgendaProj.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgendaProj.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientRepository _repository;
        public ClientController(IClientRepository clientRepository){
            _repository = clientRepository;
    }
         public IActionResult Index(){  
           var client = _repository.GetAll();
            return View(client); 
        }
         [HttpGet]
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(Client client)
        {
            _repository.Create(client);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var Client = _repository.GetById(id);
            return View(Client);
        }

        [HttpPost]
        public IActionResult Update(Client cliente)
        {
            _repository.Update(cliente);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }

    }
}