
namespace CardboardhqAPI.MarketMovers;

// Change this to the object that we return to the consumer
public class MarketMoverCardResponseDto
{
    public required string Name { get; set; }
    public required string ImageUrl { get; set; }
    public required string PrintingUniqueId { get; set; }
    public decimal StartOfWeekPrice { get; set; }
    public decimal CurrentPrice { get; set; }
    public decimal PercentageChange { get; set; }
}
