using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace CardboardhqAPI.MarketMovers;

public class MarketMoversService
{
    private readonly AppDbContext _dbContext;
    private bool _dateCheckFlag = false;

    // private readonly ILogger _logger;

    public MarketMoversService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
        //_logger = logger;
    }

    public async Task<List<MarketMoverCardResponseDto>> GetTop5WeeklyMarketMovers()
    {
        Console.WriteLine(_dateCheckFlag);
        // Use todays date or yesterday if we have any rows with todays date in the table.
        var currentDate = GetCurrentDate(_dateCheckFlag);
        var startOfWeekDate = GetStartOfWeekDate(_dateCheckFlag);

        var weeklyMarketMovers = await FetchWeeklyMarketMovers();

        var marketMoverCards = weeklyMarketMovers
            .GroupBy(p => new { p.PrintingUniqueId })
            .Select(g => new
            {
                Name = g.Select(p => p.CardName).FirstOrDefault(),
                ImageUrl = g.Select(p => p.ImageUrl).FirstOrDefault(),
                Card = g.Key,
                StartOfWeekPrice = g.Where(p => p.PriceDate == startOfWeekDate).Select(p => p.LowPrice).FirstOrDefault(),
                CurrentPrice = g.Where(p => p.PriceDate == currentDate).Select(p => p.LowPrice).FirstOrDefault()
            })
            .Where(p => p.StartOfWeekPrice > 0 && p.CurrentPrice > 0)
            .Select(result => new MarketMoverCardResponseDto
            {
                Name = result.Name!,
                ImageUrl = result.ImageUrl!,
                PrintingUniqueId = result.Card.PrintingUniqueId,
                StartOfWeekPrice = result.StartOfWeekPrice,
                CurrentPrice = result.CurrentPrice,
                PercentageChange = result.StartOfWeekPrice! > 0
                    ? (result.CurrentPrice! - result.StartOfWeekPrice!) / result.StartOfWeekPrice! * 100
                    : 0
            })
            .Where(p => p.PercentageChange > 70.00M)
            .OrderByDescending(p => p.PercentageChange)
            .Take(5)
            .ToList();

        return marketMoverCards;
    }

    public async Task<IEnumerable<AllHighRarityPrintingsWithCardPricesWeekly>> FetchWeeklyMarketMovers()
    {
        var dateCheckFlag = await DateCheckFlagAsync();

        // Use todays date or yesterday if we have any rows with todays date in the table.
        var currentDate = GetCurrentDate(dateCheckFlag);
        var startOfWeekDate = GetStartOfWeekDate(dateCheckFlag);


        // Filter data by date and low_price
        var weeklyMarketMovers = await _dbContext.AllHighRarityPrintingsWithCardPricesWeekly
            .Where(p => p.LowPrice > 1.5M)
            .Where(p => p.PriceDate == startOfWeekDate || p.PriceDate == currentDate)
            .ToListAsync();

        return weeklyMarketMovers;
    }
    public async Task<bool> DateCheckFlagAsync()
    {
        if (_dateCheckFlag)
        {
            return _dateCheckFlag; // Return cached value
        }

        var dateFlag = await _dbContext.AllHighRarityPrintingsWithCardPricesWeekly
            .Where(p => p.PriceDate == DateOnly.FromDateTime(DateTime.Today))
            .Take(1)
            .AnyAsync();

        _dateCheckFlag = dateFlag; // Cache the result
        return dateFlag;
    }


    public DateOnly GetCurrentDate(bool dateFlag)
    {
        return DateOnly.FromDateTime(dateFlag ? DateTime.Today : DateTime.Today.AddDays(-1));
    }

    public DateOnly GetStartOfWeekDate(bool dateFlag)
    {
        return DateOnly.FromDateTime(DateTime.Today.AddDays(dateFlag ? -6 : -7));

    }
}
