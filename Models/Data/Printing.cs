using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardboardhqAPI;

public partial class Printing
{
    [Key]
    public string UniqueId { get; set; } = null!;

    public string? CardUniqueId { get; set; }

    public string? SetPrintingUniqueId { get; set; }

    public string? Id { get; set; }

    public string? SetId { get; set; }

    public char? Edition { get; set; }

    public char? Foiling { get; set; }

    public char? Rarity { get; set; }

    public string? Artist { get; set; }
    public string? ArtVariation { get; set; }
    public string? FlavorText { get; set; }

    public string? FlavorTextPlain { get; set; }

    public string? ImageUrl { get; set; }

    public string? TcgplayerProductId { get; set; }

    public string? TcgplayerUrl { get; set; }

    public List<string>? ArtistArray { get; set; }

    public bool? IsFront { get; set; }

    public string? OtherFaceUniqueId { get; set; }
    public bool? IsDfc { get; set; }

    public virtual Card? CardUnique { get; set; }

    public virtual ICollection<DoubleSidedCardInfo> DoubleSidedCardInfos { get; set; } = new List<DoubleSidedCardInfo>();

    public virtual ICollection<PortfolioCard> PortfolioCards { get; set; } = new List<PortfolioCard>();
}
