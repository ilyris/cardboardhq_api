using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CardboardhqAPI.Cards
{
    [ApiController]
    public class PrintingController : BaseController
    {
        private readonly AppDbContext _dbContext;

        public PrintingController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPrintingById(string id)
        {
            Console.WriteLine(id);
            var printing = await _dbContext.Printing.FindAsync(id);

            if (printing == null)
            {
                return NotFound();
            }

            return Ok(printing);
        }

        // Returns Printing obj
        private static GetPrintingResponse PrintingToGet(Printing printing)
        {
            return new GetPrintingResponse
            {
                Unique_Id = printing.Unique_Id,
                Set_Printing_Unique_Id = printing.Set_Printing_Unique_Id,
                Id = printing.Id,
                Set_Id = printing.Set_Id,
                Edition = printing.Edition,
                Foiling = printing.Foiling,
                Rarity = printing.Rarity,
                Artist = printing.Artist,
                Art_Variation = printing.Art_Variation,
                Flavor_Test = printing.Flavor_Test,
                Flavor_Text_Plain = printing.Flavor_Text_Plain,
                Image_Url = printing.Image_Url,
                Tcgplayer_Product_Id = printing.Tcgplayer_Product_Id,
                Tcgplayer_Url = printing.Tcgplayer_Url,
                Artist_Array = printing.Artist_Array
            };
        }
    }
}
