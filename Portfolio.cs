using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CardboardhqAPI;

public partial class Portfolio
{
    [Key]
    public string UniqueId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public Guid? UserId { get; set; }

    public virtual ICollection<Card> Cards { get; set; } = new List<Card>();

    public virtual ICollection<PortfolioCard> PortfolioCards { get; set; } = new List<PortfolioCard>();

    public virtual ICollection<PortfolioPrice> PortfolioPrices { get; set; } = new List<PortfolioPrice>();

    public virtual User? User { get; set; }
}
