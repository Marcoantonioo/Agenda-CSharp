using System.Collections.Generic;

namespace AgendaProj.Models

{
    public interface IClientRepository
    {
         void Create(Client client);
         List<Client> GetAll();
        Client GetById(int id);
        void Delete(int id);
        void Update(Client cliente);
    }
}