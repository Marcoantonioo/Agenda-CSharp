using System.Collections.Generic;

namespace AgendaProj.Models
{
    public interface ISituacaoRepository
    {
        void Create(Situacao situacao);
        List<Situacao> GetAll();
        void Update(Situacao situacao);
        Situacao GetById(int id);
        void Delete(int id);
    }
}