using System;
using System.Collections.Generic;

namespace CardboardhqAPI;

public partial class PortfolioWithLatestPrice
{
    public string? PortfolioName { get; set; }

    public string? PortfolioUniqueId { get; set; }

    public Guid? UserId { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public DateTime? PriceTimestamp { get; set; }
}
