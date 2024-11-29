using System;
using System.Collections.Generic;

namespace CardboardhqAPI;

public partial class ProductPrices202409
{
    public int ProductId { get; set; }

    public DateOnly Date { get; set; }

    public string SubTypeName { get; set; } = null!;

    public decimal? LowPrice { get; set; }

    public decimal? MidPrice { get; set; }

    public decimal? HighPrice { get; set; }

    public decimal? MarketPrice { get; set; }

    public decimal? DirectLowPrice { get; set; }
}
