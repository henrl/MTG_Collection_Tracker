namespace Glee_Max.Web.Services
{
    using System.Collections.Generic;
    using Glee_Max.Web.Dtos;
    using Glee_Max.Web.Models;

    public interface ICardService
    {
        List<Card> GetCardsBySearch(Search search);

        bool UpdateCardQuantity(CardAmountUpdateDto update);
    }
}