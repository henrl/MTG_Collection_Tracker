namespace Glee_Max.Web.Helpers
{
    using Glee_Max.Web.Dtos;
    using Glee_Max.Web.Models;

    public static class Mapper
    {
        public static CardDto MapToCardDto(Card card)
        {
            return new CardDto
            {
                Id = card.Id,
                Name = card.Name,
                Uri = card.Uri,
                ScryfallUri = card.ScryfallUri,
                ManaCost = card.ManaCost,
                Cmc = card.Cmc,
                TypeLine = card.TypeLine,
                OracleText = card.OracleText,
                Colors = card.Colors,
                ColorIdentity = card.ColorIdentity,
                SetName = card.SetName,
                Power = card.Power,
                Toughness = card.Toughness,
                FlavorText = card.FlavorText,
                CommanderLegal = card.CommanderLegal,
                Quantity = card.Quantity
            };
        }
    }
}