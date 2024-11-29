using System;

namespace CardboardhqAPI.Sets;

public class Set
{
    public required string Unique_Id { get; set; }
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required string Formatted_Name { get; set; }
    public List<SetPrinting> SetPrinting { get; set; } = new List<SetPrinting>();
}
