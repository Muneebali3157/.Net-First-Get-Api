using First_crud_operation.Models;
using Microsoft.EntityFrameworkCore;

namespace First_crud_operation
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        
        public DbSet<Userprofile> Userprofiles { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
