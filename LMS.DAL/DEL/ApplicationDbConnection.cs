using LMS.Models;
using Microsoft.EntityFrameworkCore;

namespace LMS.DAL.DEL
{
	public class ApplicationDbConnection : DbContext
	{
		public ApplicationDbConnection(DbContextOptions<ApplicationDbConnection> options) : base(options)
		{

		}

		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }


	}
}
