using System.Collections.Generic;
using System.Linq;
using AgendaProj.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendaProj.Models
{
    public class AgendaRepository : IAgendaRepository
        {
            private DataContext dataContext;
        public AgendaRepository(DataContext dataContext)
        {           
            this.dataContext = dataContext;
        }
        
        public void Create(Agenda agenda)
        {
            agenda.sit = dataContext.Situacao.Find(agenda.sit.id);
            agenda.client = dataContext.Client.Find(agenda.client.id);
            dataContext.Add(agenda);
            dataContext.SaveChanges();
        }
        public List<Agenda> GetAll()
        {
            return dataContext.Agenda.Include(x=>x.sit).Include(c => c.client).ToList();
        }
        
        public void Update(Agenda agenda)
        {
            agenda.duracao = agenda.horaFim.Subtract(agenda.horaInicio);
            agenda.sit = dataContext.Situacao.Find(agenda.sit.id);
            dataContext.Entry(agenda).State = EntityState.Modified;
            
            dataContext.SaveChanges();
        }
        public Agenda GetById(int id)
        {
            return dataContext.Agenda.Include(s => s.sit).Include(c => c.client).SingleOrDefault(x => x.id == id);
        }
        
        public void Delete(int id)
        {
            dataContext.Remove(GetById(id));
            dataContext.SaveChanges();
        }
    
        
    }
}