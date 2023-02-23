using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace carrent.Data
{
    public class CarDbContext : IdentityDbContext<Clieunt>
    {
        public CarDbContext(DbContextOptions<CarDbContext> options)
            : base(options)
        {
        }
        public DbSet<Car> Cars;
        public DbSet<Rezervation> Rezerations;
        public DbSet<BrandModel> Brands;
    }
}