using System;

namespace AgendaProj.Models
{
    public class Agenda
    {
        public Agenda(){}
        public Agenda(int id, string name, string email, int fone, string descricao, int numChamada,
        DateTime data, TimeSpan horaInicio, TimeSpan horaFim, Client client, Situacao sit
        ){
            this.id = id;
            this.name = name;
            this.email = email;
            this.fone = fone;
            this.descricao = descricao;
            this.numChamada = numChamada;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaFim = horaFim;
            this.client = client;
            this.sit = sit;
            
            
        }
        public int id{get; set;}
        public string name{get; set;}
        public string email{get; set;}
        public int fone{get; set;}
        public string descricao{get; set;}
        public int numChamada{get;set;}
        public DateTime data{get; set;}
        public TimeSpan horaInicio{get;set;}
        public TimeSpan horaFim{get;set;}
        public TimeSpan duracao{get;set;}
        public Client client {get;set;}
        public Situacao sit {get;set;}
    }   
}