namespace Glee_Max.Web.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using Glee_Max.Web.Models;

    public class CardService : ICardService
    {
        private readonly CardContext _context;

        public CardService(CardContext context)
        {
            _context = context;
        }

        public List<Card> GetAllCards()
        {
            //TODO: refine the select statement here so there's some mapping between db entity and dto
            return _context.Cards.Select(c => c).ToList();
        }

        public List<Card> GetCardsByName(string name)
        {
            //TODO: refine the search criteria here
            return _context.Cards.Where(c => c.Name.Contains(name)).ToList();
        }
    }
}