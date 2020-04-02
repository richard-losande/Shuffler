using System;
using System.Collections.Generic;
using System.Text;
using Shuffler.Common;
using Shuffler.Common.Enums;

namespace Shuffler.Business.Helper
{
    public interface ICard
    {
        string GetCardType(Enumerations.CardTypeEnum cardType);
    }
}
