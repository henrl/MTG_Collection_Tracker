namespace Glee_Max.Web
{
    using Glee_Max.Web.Models;
    using Microsoft.EntityFrameworkCore;

    public class CardContext : DbContext
    {
        public CardContext(DbContextOptions<CardContext> options) : base(options) { }

        public DbSet<Card> Cards { get; set; }
    }
}