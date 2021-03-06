namespace Glee_Max.Web.Dtos
{
    public class CardDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Uri { get; set; }

        public string ScryfallUri { get; set; }

        public string ManaCost { get; set; }

        public decimal Cmc { get; set; }

        public string TypeLine { get; set; }

        public string OracleText { get; set; }

        public string Colors { get; set; }

        public string ColorIdentity { get; set; }

        public string SetName { get; set; }

        public string Power { get; set; }

        public string Toughness { get; set; }

        public string FlavorText { get; set; }

        public bool CommanderLegal { get; set; }

        public int Quantity { get; set; }
    }
}