using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CRUD1.Models
{
    public class Context : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Calendar> Calendarios { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}