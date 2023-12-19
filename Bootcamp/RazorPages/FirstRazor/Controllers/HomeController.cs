using FirstRazor.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstRazor.Controllers
{
	public class HomeController : Controller
	{
		[Route("home")]
		[Route("/")]
		public IActionResult Index()
		{
			ViewData["appTitle"] = "Asp.Net Core Demo App";
			List<Person> people = new List<Person>()
			{
				new Person(){Name="John",DateOfBirth=DateTime.Parse("2000-05-06"),PersonGender=Gender.Male},
				new Person(){Name="Linda",DateOfBirth=DateTime.Parse("2002-01-09"),PersonGender=Gender.Female},
				new Person(){Name="Susan",DateOfBirth=DateTime.Parse("2004-07-12"),PersonGender=Gender.Other}
			};
			//ViewData["people"] = people;
			ViewBag.people = people;
			return View("Index", people); //default route // Views/Home/Index.cshtml 

			//return View("abc")
		}
		[Route("person-details/{name}")]
		public IActionResult Details(string? name)
		{
			if (name == null)
			{
				return Content("Person name cannot be null");
			}
			List<Person> people = new List<Person>()
			{
				new Person(){Name="John",DateOfBirth=DateTime.Parse("2000-05-06"),PersonGender=Gender.Male},
				new Person(){Name="Linda",DateOfBirth=DateTime.Parse("2002-01-09"),PersonGender=Gender.Female},
				new Person(){Name="Susan",DateOfBirth=DateTime.Parse("2004-07-12"),PersonGender=Gender.Other}
			};
			Person? matchingPerson = people.Where(temp => temp.Name == name).FirstOrDefault();
			return View(matchingPerson);
		}
		[Route("person-with-product")]
		public IActionResult PersonWithProduct()
		{
			Person person = new Person()
			{
				Name = "Sara",
				PersonGender = Gender.Female,
				DateOfBirth = Convert.ToDateTime("2002-04-12")
			};

			Product product = new Product()
			{
				ProductId = 1,
				ProductName = "Air Conditioner"
			};
			PersonAndProductWrapperModel wrappedModel = new PersonAndProductWrapperModel()
			{
				PersonData = person,
				ProductData = product
			};
			return View(wrappedModel);
		}
	}
}
