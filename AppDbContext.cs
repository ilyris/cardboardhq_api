using CardboardhqAPI.Cards;
using Microsoft.EntityFrameworkCore;

namespace CardboardhqAPI;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<Printing> Printing { get; set; }
}
