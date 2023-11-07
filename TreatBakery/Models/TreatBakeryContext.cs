using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TreatBakery.Models
{
  public class TreatBakeryContext: IdentityDbContext<ApplicationUser>
  {
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<Treat> Treats { get; set; }
    public DbSet<TreatFlavor> TreatFlavors { get; set; }

    public TreatBakeryContext(DbContextOptions options) : base(options) { }
  }
}