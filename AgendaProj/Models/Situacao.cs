namespace AgendaProj.Models
{
    public class Situacao
    {
        public Situacao(){}
        public Situacao(int id, string sit){
            this.id = id;
            this.sit = sit;
        }
        public int id { get; set; }
        public string sit { get; set;}
    }
}