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
    }
}