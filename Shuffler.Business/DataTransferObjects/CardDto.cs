using System;
using System.Collections.Generic;
using System.Text;
using Shuffler.Common.Enums;

namespace Shuffler.Business.DataTransferObjects
{
    public class CardDto
    {
        public int CardNumber { get; set; }
        public string CardType { get; set; }
        public Enumerations.CardTypeEnum CardTypeEnum { get; set; }
    }
}
