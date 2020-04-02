namespace Glee_Max.Web.Controllers
{
    using System;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Glee_Max.Web.Dtos;
    using Glee_Max.Web.Helpers;
    using Glee_Max.Web.Services;

    public class CardController : Controller
    {
        private readonly ICardService _cardService;

        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_cardService.GetAllCards()
                .Select(Mapper.MapToCardDto)
                .ToList());
        }

        [HttpGet("{name}")]
        public IActionResult GetCardsByName(string name)
        {
            return Ok(_cardService.GetCardsByName(name)
                .Select(Mapper.MapToCardDto)
                .ToList());
        }
    }
}