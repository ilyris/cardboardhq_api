using System;
using System.Collections.Generic;

namespace CardboardhqAPI;

public partial class AllHighRarityPrintingsWithCardPricesWeekly
{
    public string? PrintingUniqueId { get; set; }

    public string? SetPrintingUniqueId { get; set; }

    public string? PrintingId { get; set; }

    public string? SetId { get; set; }

    public char? Rarity { get; set; }

    public char? Edition { get; set; }

    public char? Foiling { get; set; }

    public string? Artist { get; set; }

    public string? ImageUrl { get; set; }

    public string? TcgplayerProductId { get; set; }

    public string? TcgplayerUrl { get; set; }

    public string? CardUniqueId { get; set; }

    public string? CardName { get; set; }

    public decimal? LowPrice { get; set; }

    public decimal? MarketPrice { get; set; }

    public DateOnly? PriceDate { get; set; }

    public string? SubTypeName { get; set; }

    public List<string>? ArtistArray { get; set; }
}
