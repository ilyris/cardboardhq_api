using System;

namespace CardboardhqAPI.Cards;

public class Card
{
    public required string Unique_Id { get; set; }
    public required string Name { get; set; }
    public required List<Printing> Printings { get; set; } = new List<Printing>();
}