using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace MVCwebApplication.Models
{

    // context in name is a good practice for evrbdy to know it`s a relation to DB
    public class VolleyballDBcontext : DbContext

    {

        public VolleyballDBcontext(DbContextOptions<VolleyballDBcontext> options) : base(options) 
        { 
        }
    

    }
}
