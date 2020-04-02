using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Shuffler.Business.Tests.Mocks;
using Shuffler.Business.LogicCollection;
using System.Linq;
using FluentAssertions;
using Shuffler.Common.Enums;
using Moq;

namespace Shuffler.Business.Tests.Card
{
    [TestFixture]
    public class CardBusinessTest
    {
        private CardBusinessMock _moq;

        [SetUp]
        public void SetUpResources()
        {
            _moq = new CardBusinessMock();
        }
        [Test]
        public void GetAllCards_ShouldNotThrowException_WhenReturn52CountOfCards()
        {
            //arrange
            var expectedResult = 52;

            _moq.Card.Setup(a => a.GetCardType(It.IsAny<Enumerations.CardTypeEnum>())).Returns(It.IsAny<string>());

            var cardBusiness = new CardBusiness(_moq.Card.Object);
            //act
            var result = cardBusiness.GetInitialCardArrangement().Count();
            //assert
            result.Should().Equals(expectedResult);
        }

        [Test]
        public void ShuffleCards_ShouldNotThrowException_WhenReturn52CountOfCards()
        {
            //arrange
            var expectedResult = 52;

            _moq.Card.Setup(a => a.GetCardType(It.IsAny<Enumerations.CardTypeEnum>())).Returns(It.IsAny<string>());

            var cardBusiness = new CardBusiness(_moq.Card.Object);
            //act
            var result = cardBusiness.ShuffleCards().Count();
            //assert
            result.Should().Equals(expectedResult);
        }    
    }
}
