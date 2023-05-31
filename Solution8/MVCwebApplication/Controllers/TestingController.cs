using Microsoft.AspNetCore.Mvc;
using MVCwebApplication.Models;

namespace MVCwebApplication.Controllers
{
    public class TestingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SampleText()
        {
            // dynamic type for testing
            ViewBag.MyOwnMessage = "Good to go!";
            ViewBag.Title = "Title me this";
            return View();
        }

        public IActionResult PersonsList()
        {
            var persons = new List<Person>();
            {
                new Person { Id = 1, Name = "A", Age = 1 };
                new Person { Id = 2, Name = "B", Age = 2 };
                new Person { Id = 3, Name = "C", Age = 3 };
            };

            return View(persons);
        }
    }
}
