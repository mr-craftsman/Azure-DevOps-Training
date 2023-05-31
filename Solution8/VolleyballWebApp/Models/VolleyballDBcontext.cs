using Microsoft.EntityFrameworkCore;

namespace VolleyballWebApp.Models
{

    // context in name is a good practice for evrbdy to know it`s a relation to DB
    public class VolleyballDBcontext : DbContext

    {

        public VolleyballDBcontext(DbContextOptions<VolleyballDBcontext> options) : base(options) 
        { 
        }
    


        public DbSet<VolleyballPlayer> VolleyballPlayers { get; set; }
    }
}
