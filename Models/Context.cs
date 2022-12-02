using Microsoft.EntityFrameworkCore;

//Here I make the MovieContext file, making sure to use the DbSet
namespace Final_Project_CarBag.Models
{
	public class Context : DbContext
	{
		public Context (DbContextOptions<Context> options)
			: base(options)
		{
		}
		public DbSet<Car> cars {get; set;} = default!;
		public DbSet<Seller> sellers {get; set;} = default!;
	}
}