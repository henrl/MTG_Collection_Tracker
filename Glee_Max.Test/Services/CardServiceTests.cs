namespace Glee_Max.Test.Services
{
    using System;
    using System.Linq;
    using Glee_Max.Web;
    using Glee_Max.Web.Dtos;
    using Glee_Max.Web.Models;
    using Glee_Max.Web.Services;
    using Microsoft.EntityFrameworkCore;
    using NUnit.Framework;

    public class CardServiceTests
    {
        private CardContext _dbContext;
        private CardService _cardService;

        [SetUp]
        public void SetUp()
        {
            _dbContext = GetContextWithData();
            _cardService = new CardService(_dbContext);
        }

        [Test]
        public void CardSearchByExactString_ReturnsValidOutput()
        {
            var search = new Search { SearchString = "Another test Card, this is" };
            var results = _cardService.GetCardsBySearch(search);

            Assert.AreEqual(1, results.Count);
            Assert.AreEqual(2, results.First().Id);
            Assert.AreEqual(search.SearchString, results.First().Name);
        }

        private CardContext GetContextWithData()
        {
            var options = new DbContextOptionsBuilder<CardContext>()
                            .UseInMemoryDatabase(Guid.NewGuid().ToString())
                            .Options;

            var dbContext = new CardContext(options);
            dbContext.Cards.Add(new Card { Id = 1, Name = "Test Card" });
            dbContext.Cards.Add(new Card { Id = 2, Name = "Another test Card, this is" });
            dbContext.SaveChanges();

            return dbContext;
        }
    }
}