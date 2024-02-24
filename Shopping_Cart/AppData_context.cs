namespace Shopping_Cart.Data;

public class AppData_Context : security_db_context
{
    public AppData_Context(DbContextOptions<AppData_context> options)
        :base(options)
        {}
	
	public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; } 

}
