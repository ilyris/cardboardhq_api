using CardboardhqAPI.Cards;
using Microsoft.EntityFrameworkCore;

namespace CardboardhqAPI;

public class AppDbContext : DbContext {

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<AllHighRarityPrintingsWithCardPricesWeekly> AllHighRarityPrintingsWithCardPricesWeekly { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Explicitly map the Printing class to the 'printing' table in the database
        modelBuilder.Entity<AllHighRarityPrintingsWithCardPricesWeekly>().ToTable("all_high_rarity_printings_with_card_prices_weekly");

        // Apply the snake_case convention to all properties
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            foreach (var property in entityType.GetProperties())
            {
                // Automatically convert property names to snake_case
                property.SetColumnName(ToSnakeCase(property.Name));
            }
        }

        base.OnModelCreating(modelBuilder);
    }

        private string ToSnakeCase(string name)
    {
        // Regex to insert an underscore before each uppercase letter and make it lowercase
        return string.Concat(
            name
                .Select((x, i) => i > 0 && Char.IsUpper(x) ? "_" + x.ToString().ToLower() : x.ToString().ToLower())
        ).ToLower();
    }
}
