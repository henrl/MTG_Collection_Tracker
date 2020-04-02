namespace Glee_Max.Web.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;
    using Glee_Max.Web.Services;

    public class CardController : Controller
    {
        private readonly ICardService _cardService;

        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}