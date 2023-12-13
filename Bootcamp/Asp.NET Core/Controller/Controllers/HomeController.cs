using Controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.controllers
{
    [Controller]
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("home")]
        [HttpGet]
        public ContentResult Index()
        {
            return Content("<h1>Welcome</h1><h2>Hello from Home</h2>", "text/html");
        }
        [Route("about")]
        public ContentResult About()
        {
            return Content("Hello from About");
        }

        [Route("person")]
        public JsonResult Person()
        {
            Person person = new Person()
            {
                Id = Guid.NewGuid(),
                FirstName = "Denis",
                LastName = "Diamantis",
                Age = 25
            };
            return Json(person);
        }
    }
}
