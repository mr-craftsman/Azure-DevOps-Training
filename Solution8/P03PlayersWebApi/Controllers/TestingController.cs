using Microsoft.AspNetCore.Mvc;

namespace P03PlayersWebApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TestingController : Controller
    {

        [HttpGet(Name = "GetTestingData")]  //this name is visible outside
        public string MyTestingMethod()
        {
            return "testing works";
        }
    }
}
