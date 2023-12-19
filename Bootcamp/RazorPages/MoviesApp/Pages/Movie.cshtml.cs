using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.NewFolder.Models;
using MoviesApp.Services;

namespace MoviesApp.Pages
{
	public class MovieModel : PageModel
	{
		public Movie? Movie { get; set; }

		private IMoviesService _moviesService;
		public MovieModel(IMoviesService moviesService)
		{
			_moviesService = moviesService;
		}
		public void OnGet(int id)
		{
			Movie = _moviesService.GetMovie(id);
		}
	}
}
