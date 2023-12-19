using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.NewFolder.Models;
using MoviesApp.Services;

namespace MoviesApp.Pages
{
	public class MoviesModel : PageModel
	{

		private readonly IMoviesService _moviesService;

		public List<Movie> Movies { get; set; }
		public MoviesModel(IMoviesService moviesService)
		{

			_moviesService = moviesService;
		}
		public void OnGet()
		{
			Movies = _moviesService.GetAllMovies();


			//Movies = new List<Movie>()
			//{
			//	new Movie()
			//	{
			//		Id = 1,
			//		Title = "First movie title",
			//		Rate = 10,
			//		Description="First movie description..."
			//	},
			//	new Movie()
			//	{
			//		Id = 2,
			//		Title = "Second movie title",
			//		Rate = 7,
			//		Description="Second movie description..."
			//	},
			//	new Movie()
			//	{
			//		Id = 3,
			//		Title = "Third movie title",
			//		Rate = 5,
			//		Description="Third movie description..."
			//	},
			//	new Movie()
			//	{
			//		Id = 4,
			//		Title = "Fourth movie title",
			//		Rate = 10,
			//		Description="Fourth movie description..."
			//	}
			//};
		}
	}
}
