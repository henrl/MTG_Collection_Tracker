namespace Glee_Max.Web.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using Glee_Max.Web.Models;

    public class CardService : ICardService
    {
        private const string DefaultLanguage = "en";
        private readonly CardContext _context;

        public CardService(CardContext context)
        {
            _context = context;
        }

        public List<Card> GetAllCards()
        {
            //TODO: get rid of Id < 20 filter
            return _context.Cards
                .Where(c => c.Language == DefaultLanguage && c.Id < 20)
                .ToList();
        }

        public List<Card> GetCardsByName(string name)
        {
            //TODO: refine the search criteria here
            return _context.Cards
                .Where(c => c.Name.Contains(name))
                .ToList();
        }
    }
}