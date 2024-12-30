using E_commerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Ecommerce.Data
{
	public class BancoContext : IdentityDbContext
	{
		public BancoContext(DbContextOptions<BancoContext> options) : base(options)
		{
		}

		public DbSet<LoginModel> Login { get; set; }
	}
}
