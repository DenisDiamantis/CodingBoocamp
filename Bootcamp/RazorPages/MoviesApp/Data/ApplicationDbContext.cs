using Microsoft.EntityFrameworkCore;
using MoviesApp.NewFolder.Models;

namespace MoviesApp.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{

		}

		public DbSet<Movie> Movies { get; set; }
	}
}
