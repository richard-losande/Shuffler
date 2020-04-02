using System;
using System.Collections.Generic;
using System.Text;
using Shuffler.Common.Enums;
namespace Shuffler.Business.Helper
{
    public class Card : ICard
    {
        public string GetCardType(Enumerations.CardTypeEnum cardType)
        {
            switch (cardType)
            {
                case Enumerations.CardTypeEnum.Diamond: return "Diamond";
                case Enumerations.CardTypeEnum.Heart: return "Heart";
                case Enumerations.CardTypeEnum.Flower: return "Flower";
                default: return "Spade";
            }
        }
    }
}
