using Microsoft.EntityFrameworkCore;

namespace Horecapp.Models;

public class HorecappDbContext : DbContext
{
    public HorecappDbContext(DbContextOptions<HorecappDbContext> context) : base(context) { }
    public DbSet<Restaurant> Restaurants { get; set; }
}