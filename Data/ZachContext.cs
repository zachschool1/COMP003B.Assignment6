using COMP003B.Assignment6.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.Assignment6.Data
{
    public class ZachContext : DbContext
    {
        public ZachContext(DbContextOptions<ZachContext> options) : base(options) 
        {
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movies> Moviess { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }
    }
}
