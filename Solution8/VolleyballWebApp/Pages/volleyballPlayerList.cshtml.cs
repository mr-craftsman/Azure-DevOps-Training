using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VolleyballWebApp.Models;

namespace VolleyballWebApp.Pages
{
    public class volleyballPlayerListModel : PageModel
    {

        private readonly VolleyballDBcontext _context;
        // by dependency injection
        public volleyballPlayerListModel(VolleyballDBcontext context)
        {
            _context = context;
                
        }

        public List<VolleyballPlayer> VolleyballPlayers { get; set; }

        public void OnGet()
        {
            VolleyballPlayers =  _context.VolleyballPlayers.ToList();
            
        }
    }
}
