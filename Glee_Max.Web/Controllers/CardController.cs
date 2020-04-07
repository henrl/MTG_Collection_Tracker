namespace Glee_Max.Web.Controllers
{
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Glee_Max.Web.Helpers;
    using Glee_Max.Web.Services;

    [Route("/api/cards")]
    public class CardController : Controller
    {
        private readonly ICardService _cardService;

        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }

        // TODO: change this so it works with strings with spaces in them
        [HttpGet("{name}")]
        public IActionResult GetCardsByName(string name)
        {
            return Ok(_cardService.GetCardsByName(name)
                .Select(Mapper.MapToCardDto)
                .ToList());
        }
    }
}