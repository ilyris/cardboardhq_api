using System;
using System.Collections.Generic;

namespace CardboardhqAPI;

public partial class PrintingWithCardAndPricing
{
    public string? PrintingUniqueId { get; set; }

    public string? SetPrintingUniqueId { get; set; }

    public string? PrintingId { get; set; }

    public string? SetId { get; set; }

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
}
