using MoviesApp.NewFolder.Models;

namespace MoviesApp.Services
{
	public interface IMoviesService
	{
		List<Movie> GetAllMovies();
		Movie GetMovie(int id);
		void Add(Movie movie);
	}
}
