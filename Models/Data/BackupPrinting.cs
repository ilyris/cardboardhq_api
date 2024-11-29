using System;
using System.Collections.Generic;

namespace CardboardhqAPI;

public partial class BackupPrinting
{
    public string? UniqueId { get; set; }

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
}
