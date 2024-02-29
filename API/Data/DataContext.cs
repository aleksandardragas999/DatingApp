using API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace API.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions options):base(options) { }
        public DbSet<AppUser> AppUsers { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

		}
	}
}
