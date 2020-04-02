namespace Glee_Max.Web.Services
{
    using System.Collections.Generic;
    using Glee_Max.Web.Models;

    public interface ICardService
    {
        List<Card> GetAllCards();

        List<Card> GetCardsByName(string name);
    }
}