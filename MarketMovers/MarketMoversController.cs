using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CardboardhqAPI.MarketMovers
{
    [ApiController]
    public class MarketMoversController : BaseController
    {
        private readonly MarketMoversService _marketMoverService;

        public MarketMoversController(MarketMoversService marketMoverService)
        {
            _marketMoverService = marketMoverService;
        }


        [HttpGet]
        public async Task<ActionResult<MarketMoverCardResponseDto>> GetPrintingsById()
        {
            Console.WriteLine("HERE");
            var topMarketMovers = await _marketMoverService.GetTop5WeeklyMarketMovers();

            if (topMarketMovers == null)
            {
                return NotFound();
            }
            return Ok(topMarketMovers);
        }
    }
}
