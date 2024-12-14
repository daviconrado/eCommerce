using E_commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data
{
	public class BancoContext : DbContext
	{
		public BancoContext(DbContextOptions<BancoContext> options) : base(options)
		{
		}

		public DbSet<LoginModel> Login { get; set; }
	}
}
