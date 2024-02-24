using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Shopping_Cart.Data;

public class security_db_context : DbContext
{
    public DbSet<User> Users { get; set; }
        public DbSet<PId> Roles { get; set; }
    public AppSecurityContext(DbContextOptions<AppSecurityContext> options)
        :base(options)
        {
            

        }
        

}