using System;

namespace CardboardhqAPI.Cards;

public class Card
{
    public required string Unique_Id { get; set; }
    public required string Name { get; set; }
    public required List<Printing> Printings { get; set; } = new List<Printing>();
}


public class CardInfo
{
    public string PrintingUniqueId { get; set; }
    public string SetPrintingUniqueId { get; set; }
    public string PrintingId { get; set; }
    public string SetId { get; set; }
    public string Rarity { get; set; }
    public string Edition { get; set; }
    public string Foiling { get; set; }
    public string Artist { get; set; }
    public string ImageUrl { get; set; }
    public string TcgplayerProductId { get; set; }
    public string TcgplayerUrl { get; set; }
    public string CardUniqueId { get; set; }
    public string CardName { get; set; }
    public decimal LowPrice { get; set; }
    public decimal MarketPrice { get; set; }
    public DateTime PriceDate { get; set; }
    public string SubTypeName { get; set; }
    public List<string> ArtistArray { get; set; }
}