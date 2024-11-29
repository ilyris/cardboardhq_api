using System;
using System.Collections.Generic;

namespace CardboardhqAPI;

public partial class SetPrinting
{
    public string UniqueId { get; set; } = null!;

    public char? Edition { get; set; }

    public string? StartCardId { get; set; }

    public string? EndCardId { get; set; }

    public DateTime? InitialReleaseDate { get; set; }

    public DateTime? OutOfPrintDate { get; set; }

    public string? ProductPage { get; set; }

    public string? CollectorsCenter { get; set; }

    public string? CardGallery { get; set; }

    public string? SetUniqueId { get; set; }

    public virtual Set? SetUnique { get; set; }
}
