using MoviesApp.Data;
using MoviesApp.NewFolder.Models;

namespace MoviesApp.Services
{
	public class MoviesService : IMoviesService
	{
		private readonly ApplicationDbContext _context;

		public MoviesService(ApplicationDbContext context)
		{
			_context = context;
		}
		public void Add(Movie movie)
		{
			_context.Movies.Add(movie);
			_context.SaveChanges();
		}

		public List<Movie> GetAllMovies()
		{
			return _context.Movies.ToList();
		}

		public Movie GetMovie(int id)
		{
			return _context.Movies.FirstOrDefault(x => x.Id == id);
		}
	}
}
