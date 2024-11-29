using System;
using System.Collections.Generic;

namespace CardboardhqAPI;

public partial class PortfolioAggregate
{
    public string? PortfolioId { get; set; }

    public Guid? PortfolioUserId { get; set; }

    public string? PortfolioName { get; set; }

    public string? PortfolioCardId { get; set; }

    public string? CardUniqueId { get; set; }

    public string? PrintingUniqueId { get; set; }

    public int? Quantity { get; set; }

    public string? Grade { get; set; }

    public decimal? UnitPrice { get; set; }

    public bool? UseMarketPrice { get; set; }

    public DateOnly? DateAdded { get; set; }

    public string? CardName { get; set; }

    public string? SetPrintingUniqueId { get; set; }

    public string? PrintingId { get; set; }

    public string? SetId { get; set; }

    public char? Edition { get; set; }

    public char? Foiling { get; set; }

    public string? ImageUrl { get; set; }

    public string? TcgplayerProductId { get; set; }

    public string? TcgplayerUrl { get; set; }

    public decimal? LowPrice { get; set; }

    public decimal? MarketPrice { get; set; }
}
