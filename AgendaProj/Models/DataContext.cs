using Microsoft.EntityFrameworkCore;
using AgendaProj.Models;

namespace AgendaProj.Models
{
    public class DataContext : DbContext
    {
       public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {}
        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<Client> Client{get; set;}
        public DbSet<Situacao> Situacao{get; set;}
        
    }
}