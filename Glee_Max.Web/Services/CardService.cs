namespace Glee_Max.Web.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using Glee_Max.Web.Dtos;
    using Glee_Max.Web.Models;

    public class CardService : ICardService
    {
        private const string DefaultLanguage = "en";
        private readonly CardContext _context;

        public CardService(CardContext context)
        {
            _context = context;
        }

        public List<Card> GetCardsBySearch(Search search)
        {
            if (search == null || string.IsNullOrWhiteSpace(search.SearchString))
            {
                return new List<Card>();
            }

            //TODO: refine the search criteria here
            return _context.Cards
                .Where(c => c.Name.Contains(search.SearchString))
                .ToList();
        }

        public bool UpdateCardQuantity(CardAmountUpdateDto update)
        {
            if (update == null || update.Id <= 0 || update.Quantity < 0)
            {
                return false;
            }

            var card = _context.Cards.FirstOrDefault(c => c.Id == update.Id);

            if (card == null)
            {
                return false;
            }

            card.Quantity = update.Quantity;
            _context.SaveChanges();

            return true;
        }
    }
}