using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VolleyballWebApp.Pages
{
    public class CalculatorModel : PageModel
    {

        public int Result { get; set; }
        public void OnGet()
        {


        }
        public void OnPost() 
        {
            var form = Request.Form;
            bool r1 = int.TryParse(form["Number1"], out int number1);  //Try creates a new var, if successful
            bool r2 = int.TryParse(form["Number2"], out int number2);


            if (r1 && r2) 
            { 
                int Result = number1 + number2; 
            }
            else
            {
                throw new Exception();
            }
            

        }
    }
}
