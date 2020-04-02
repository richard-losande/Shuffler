using Shuffler.Business.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shuffler.Business.LogicCollection
{
    public interface ICardBusiness
    {
        IEnumerable<CardDto> GetInitialCardArrangement();
        IEnumerable<CardDto> ShuffleCards();
    }
}
