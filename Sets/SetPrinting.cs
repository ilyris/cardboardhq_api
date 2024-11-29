using System;

namespace CardboardhqAPI.Sets;

public class SetPrinting
{
    public required string Unique_Id { get; set; }
    public required string Edition { get; set; }
    public required string Start_Card_Id { get; set; }
    public required string End_Card_Id { get; set; }
    public required string Initial_Release_Date { get; set; }
    public string? Out_Of_Print_Date { get; set; }
    public required string Product_Page { get; set; }
    public required string Collectors_Center { get; set; }
    public required string Card_Gallery { get; set; }
}
