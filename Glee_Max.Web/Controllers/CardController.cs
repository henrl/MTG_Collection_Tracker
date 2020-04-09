namespace Glee_Max.Web.Controllers
{
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Glee_Max.Web.Dtos;
    using Glee_Max.Web.Helpers;
    using Glee_Max.Web.Services;

    [Route("/api/cards")]
    [ApiController]
    public class CardController : Controller
    {
        private readonly ICardService _cardService;

        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }

        [HttpPost]
        public IActionResult GetCardsByName([FromBody]Search search)
        {
            return Ok(_cardService.GetCardsBySearch(search)
                .Select(Mapper.MapToCardDto)
                .ToList());
        }

        [HttpPut]
        public IActionResult UpdateCardQuantity([FromBody]CardAmountUpdateDto update)
        {
            return Ok(_cardService.UpdateCardQuantity(update));
        }
    }
}