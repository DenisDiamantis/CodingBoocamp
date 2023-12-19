using Microsoft.AspNetCore.Mvc;

namespace Fundamentals.Controllers
{
	public class HomeController : Controller
	{
		[Route("home")]
		[Route("/")]
		public IActionResult Index()
		{
			ViewData["appTitle"] = "Asp.Net Core Demo App";
			return View(); //default route // Views/Home/Index.cshtml 

			//return View("abc")
		}
	}
}
