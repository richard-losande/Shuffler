using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shuffler.Business.DataTransferObjects;
using Shuffler.Business.Helper;
using Shuffler.Common.Enums;

namespace Shuffler.Business.LogicCollection
{  
    public class CardBusiness : ICardBusiness
    {
        private readonly ICard _card;
        public CardBusiness(ICard card)
        {
            _card = card;
        }
        public IEnumerable<CardDto> GetInitialCardArrangement()
        {
            foreach (var cardDto in ProcessGetAllCard()) 
                yield return cardDto;
        }
        public IEnumerable<CardDto> ShuffleCards()
        {
            var cards = GetInitialCardArrangement();
            return ProcessShuffle(cards.ToList());
        }
        private IEnumerable<CardDto> ProcessShuffle(List<CardDto> cards)
        {
            Random random = new Random();
            for (int i = cards.Count() - 1; i > 0; --i)
            {
                int k = random.Next(i + 1);
                CardDto temp = cards[i];
                cards[i] = cards[k];
                cards[k] = temp;
            }
            return cards;
        }

        private IEnumerable<CardDto> ProcessGetAllCard()
        {
            for (int i = 1; i <= 13; i++)
            {
                for (int c = 1; c <= 4; c++)
                    yield return new CardDto
                    { CardNumber = i, CardTypeEnum = (Enumerations.CardTypeEnum)c, CardType = _card.GetCardType((Enumerations.CardTypeEnum)c) };
            }
        }
    }
}
