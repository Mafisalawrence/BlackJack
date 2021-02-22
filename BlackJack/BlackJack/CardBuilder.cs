using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class CardBuilder :ICardBuilder 
    {
        public Card card = new Card();
        private readonly string _cardString;
        public CardBuilder(string card)
        {
            _cardString = card;
        }
        public void SetCardType()
        {
            card.Type = CardExtension.GetCardType(_cardString);
        }
        public void SetCardValue()
        {
            card.Value = CardExtension.GetValue(_cardString);
        }
        public void SetCardSuit()
        {
            card.Suit = CardExtension.GetCardSuit(_cardString);
        }
        public Card GetCard() => card;
    }

}
