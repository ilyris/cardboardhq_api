using System;
using System.Collections.Generic;

namespace CardboardhqAPI;

public partial class Set
{
    public string UniqueId { get; set; } = null!;

    public string? Id { get; set; }

    public string Name { get; set; } = null!;

    public string? FormattedName { get; set; }

    public virtual ICollection<SetPrinting> SetPrintings { get; set; } = new List<SetPrinting>();
}
