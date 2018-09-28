using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace AgendaProj.Models
{
    public class ClientRepository : IClientRepository
    {
        private DataContext dataContext;
        public ClientRepository(DataContext dataContext)
        {           
            this.dataContext = dataContext;
        }

        public void Create(Client client)
        {
            dataContext.Add(client);
            dataContext.SaveChanges();
        }
        public List<Client> GetAll()
        {
            return dataContext.Client.ToList();
        }
        public Client GetById(int id)
        {
            return dataContext.Client.SingleOrDefault(x=>x.id == id);
        }
        public void Delete(int id)
        {
            dataContext.Client.Remove(GetById(id));
            dataContext.SaveChanges();
        }
        public void Update(Client cliente)
        {
            dataContext.Entry(cliente).State = EntityState.Modified;
            dataContext.SaveChanges();
        }
        
    }
}
    