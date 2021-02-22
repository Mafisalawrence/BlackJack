using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    public class CardExtension
    {
            public static string GetCardSuit(string cardString)
            {
                return cardString.Split(" ")[2];
            }
            public static string GetCardType(string cardString)
            {
                return cardString.Split(" ")[0];
            }
            public static int GetValue(string cardString)
            {
            Enum.TryParse(GetCardType(cardString), out CardType cardType);
            switch (cardType)
                {
                    case CardType.Ace:
                        return 11;
                    case CardType.Ten:
                    case CardType.King:
                    case CardType.Jack:
                    case CardType.Queen:
                        return 10;
                    default:
                        return (int)cardType + 1;
                }
            }
        }
}
