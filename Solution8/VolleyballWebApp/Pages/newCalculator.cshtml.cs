using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VolleyballWebApp.Pages
{
    public class newCalculatorModel : PageModel
    {

        [BindProperty]
        public int Number1 { get; set; }
        [BindProperty]
        public int Number2 { get; set; }

        [TempData] //storing data for one use
        public int AddResult { get; set; }
        [TempData]
        public int SubstractResult { get; set; }


        public void OnGet()
        {
        }

        public void OnPostAdd()
        {
            int result = Number1 + Number2;
            // the number are Binded so can calculate just like that
        }

        public void OnPostSubstract()
        {
            int result = Number1 - Number2;
            // the number are Binded so can calculate just like that
        }
    }
}
