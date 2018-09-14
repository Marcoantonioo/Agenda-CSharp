using System.Collections.Generic;
using AgendaProj.Models;
namespace AgendaProj.Models
{
    public interface IAgendaRepository
    {
                    
        void Create(Agenda agenda);
        List<Agenda> GetAll();
        void Update(Agenda agenda);
        Agenda GetById(int id);
        void Delete(int id);
    }
}