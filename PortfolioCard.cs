using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CardboardhqAPI;

public partial class PortfolioCard
{
    [Key]
    public string UniqueId { get; set; } = null!;

    public string? CardUniqueId { get; set; }

    public string? PrintingUniqueId { get; set; }

    public int? Quantity { get; set; }

    public string? Grade { get; set; }

    public decimal? UnitPrice { get; set; }

    public bool? UseMarketPrice { get; set; }

    public DateOnly? DateAdded { get; set; }

    public string? PortfolioUniqueId { get; set; }

    public virtual Card? CardUnique { get; set; }

    public virtual Portfolio? PortfolioUnique { get; set; }

    public virtual Printing? PrintingUnique { get; set; }
}
