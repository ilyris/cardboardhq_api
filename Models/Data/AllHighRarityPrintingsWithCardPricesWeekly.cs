using System;
using Microsoft.EntityFrameworkCore;

namespace CardboardhqAPI;

[Keyless]
public partial class AllHighRarityPrintingsWithCardPricesWeekly
{
    public required string PrintingUniqueId { get; set; }

    public required string SetPrintingUniqueId { get; set; }

    public required string PrintingId { get; set; }

    public required string SetId { get; set; }

    public char Rarity { get; set; }

    public char Edition { get; set; }

    public char Foiling { get; set; }

    public string? Artist { get; set; }

    public required string ImageUrl { get; set; }

    public string? TcgplayerProductId { get; set; }

    public string? TcgplayerUrl { get; set; }

    public required string CardUniqueId { get; set; }

    public required string CardName { get; set; }

    public decimal LowPrice { get; set; }

    public decimal? MarketPrice { get; set; }

    public DateOnly PriceDate { get; set; }

    public string? SubTypeName { get; set; }

    public List<string>? ArtistArray { get; set; }

}