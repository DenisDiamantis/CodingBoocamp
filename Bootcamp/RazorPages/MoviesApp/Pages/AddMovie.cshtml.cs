using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.NewFolder.Models;
using MoviesApp.Services;

namespace MoviesApp.Pages
{
	public class AddMovieModel : PageModel
	{


		[BindProperty]
		public string Title { get; set; }
		[BindProperty]
		public int Rate { get; set; }
		[BindProperty]
		public string Description { get; set; }
		public void OnGet()
		{

		}
		private readonly IMoviesService _moviesService;

		public AddMovieModel(IMoviesService moviesService)
		{
			_moviesService = moviesService;
		}
		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}
			var movie = new Movie()
			{
				Title = Title,
				Rate = Rate,
				Description = Description
			};
			_moviesService.Add(movie);
			return Redirect("Movies");
		}
	}
}
