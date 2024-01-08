using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace GalleGurme.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<GalleGurme.Areas.Admin.Models.Category>? Category { get; set; }
		public DbSet<GalleGurme.Areas.Admin.Models.Menu>? Menu { get; set; }
		public DbSet<GalleGurme.Areas.Admin.Models.Products>? Products { get; set; }
		
	}
}