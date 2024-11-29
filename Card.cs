using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CardboardhqAPI;

public partial class Card
{
    [Key]
    public string UniqueId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Pitch { get; set; }

    public string? Cost { get; set; }

    public string? Power { get; set; }

    public string? Defense { get; set; }

    public string? Health { get; set; }

    public string? Intelligence { get; set; }

    public string? FunctionalText { get; set; }

    public string? FunctionalTextPlain { get; set; }

    public string? TypeText { get; set; }

    public bool? PlayedHorizontally { get; set; }

    public bool? BlitzLegal { get; set; }

    public bool? CcLegal { get; set; }

    public bool? CommonerLegal { get; set; }

    public bool? BlitzLivingLegend { get; set; }

    public bool? CcLivingLegend { get; set; }

    public bool? BlitzBanned { get; set; }

    public bool? CcBanned { get; set; }

    public bool? CommonerBanned { get; set; }

    public bool? UpfBanned { get; set; }

    public bool? BlitzSuspended { get; set; }

    public bool? CcSuspended { get; set; }

    public bool? CommonerSuspended { get; set; }

    public bool? LlRestricted { get; set; }

    public string? PortfolioId { get; set; }

    public virtual Portfolio? Portfolio { get; set; }

    public virtual ICollection<PortfolioCard> PortfolioCards { get; set; } = new List<PortfolioCard>();

    public virtual ICollection<Printing> Printings { get; set; } = new List<Printing>();
}
