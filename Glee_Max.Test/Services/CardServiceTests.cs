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
    using NSubstitute;

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

        [Test]
        public void CardUpdateWithValidNumber_ReturnsTrue()
        {
            var update = new CardAmountUpdateDto { Id = 1, Quantity = 40 };
            var success = _cardService.UpdateCardQuantity(update);
            Assert.IsTrue(success);

            var search = new Search { SearchString = "Test Card" };
            var result = _cardService.GetCardsBySearch(search).First(c => c.Id == 1);
            Assert.AreEqual(40, result.Quantity);
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