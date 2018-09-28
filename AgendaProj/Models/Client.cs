using System.Collections.Generic;

namespace AgendaProj.Models
{
    public class Client
    {
        public Client(){}
        public Client(int id, string nome, string email, int fone){
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.fone = fone;
        }
        public int id {get; set;}
        public string nome { get; set; }
        public string email { get; set; }   
        public int fone { get; set; }
        
    }

}