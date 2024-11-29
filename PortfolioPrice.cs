using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CardboardhqAPI;

public partial class PortfolioPrice
{
    [Key]
    public int Id { get; set; }

    public string? PortfolioId { get; set; }

    public decimal? Price { get; set; }

    public DateTime? PriceTimestamp { get; set; }

    public virtual Portfolio? Portfolio { get; set; }
}
