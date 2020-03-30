using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TravelApi.Models
{
  public class TravelApiContext : IdentityDbContext<ApplicationUser>
  {
    public TravelApiContext(DbContextOptions<TravelApiContext> options)
      : base(options)
    {
    }
    
    public DbSet<Review> Reviews { get; set; }
  }
}