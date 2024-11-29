using System;
using CardboardhqAPI.Cards;

namespace CardboardhqAPI.Portfolios;

public class Portfolio
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public List<Card>? Cards { get; set; }
    public required int InitialPortfolioCost { get; set; }
    public required int RecentPortfolioCostChange { get; set; }
}

public struct ReturnData
{
    public decimal Usd { get; }
    public string Percentage { get; }

    public ReturnData(decimal usd, string percentage)
    {
        Usd = usd;
        Percentage = percentage;
    }
}

public class PortfolioHoldingAdjustment
{
    public ReturnData TodaysReturn { get; set; }
    public ReturnData TotalReturn { get; set; }
}