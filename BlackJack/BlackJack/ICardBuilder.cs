using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public interface ICardBuilder
    {
        void SetCardType();
        void SetCardValue();
        void SetCardSuit();
        Card GetCard();
    }
}
