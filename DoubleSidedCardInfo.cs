using System;
using System.Collections.Generic;

namespace CardboardhqAPI;

public partial class DoubleSidedCardInfo
{
    public int Id { get; set; }

    public string OtherFaceUniqueId { get; set; } = null!;

    public bool IsFront { get; set; }

    public bool IsDfc { get; set; }

    public string? PrintingUniqueId { get; set; }

    public virtual Printing? PrintingUnique { get; set; }
}
