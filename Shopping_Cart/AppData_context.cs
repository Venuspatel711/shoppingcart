namespace IdentityAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace AuthenticatedAPI.Data;

public class AppData_Context : DbContext
{
    public AppDataContext(DbContextOptions<AppDataContext> options)
        :base(options)
        {}
	
	public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; } 

}
