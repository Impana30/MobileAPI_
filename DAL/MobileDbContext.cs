using Entity_Layer;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class MobileDbContext : DbContext
    {
        public MobileDbContext(DbContextOptions<MobileDbContext> options) : base(options)
        {
        }
        public DbSet<MobileModel> MobileModels { get; set; }

        public DbSet<CartModel> CartModels { get; set; }  
    }
}