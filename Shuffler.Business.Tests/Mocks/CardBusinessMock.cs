using Moq;
using Shuffler.Business.Helper;

namespace Shuffler.Business.Tests.Mocks
{
    internal class CardBusinessMock
    {
        public MockRepository MockRepository { get; }
        public Mock<ICard> Card { get; set; }
        public CardBusinessMock()
        {
            MockRepository = new MockRepository(MockBehavior.Strict);
            Card = MockRepository.Create<ICard>();
        }
    }
}
