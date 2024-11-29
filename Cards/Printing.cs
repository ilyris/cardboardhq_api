using System;

namespace CardboardhqAPI.Cards;

public class Printing
{
    public required string Unique_Id { get; set; }
    public required string Set_Printing_Unique_Id { get; set; }
    public required string Id { get; set; }
    public required string Set_Id { get; set; }
    public required string Edition { get; set; }
    public required string Foiling { get; set; }
    public required string Rarity { get; set; }
    public required string Artist { get; set; }
    public string? Art_Variation { get; set; }
    public required string Flavor_Test { get; set; }
    public required string Flavor_Text_Plain { get; set; }
    public required string Image_Url { get; set; }
    public required string Tcgplayer_Product_Id { get; set; }
    public required string Tcgplayer_Url { get; set; }
    public required List<string> Artist_Array { get; set; } = new List<string>();
}
