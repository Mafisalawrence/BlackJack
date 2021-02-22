using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class CardGenerator
    {
        private readonly ICardBuilder _cardBuilder;
        public CardGenerator(ICardBuilder cardBuilder)
        {
            _cardBuilder = cardBuilder;
        }
        public void GenerateCard()
        {
            _cardBuilder.SetCardSuit();
            _cardBuilder.SetCardType();
            _cardBuilder.SetCardValue();
        }
    }
}
