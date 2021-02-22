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
                switch (GetCardType(cardString))
                {
                    case CardType.Ace:
                        return 11;
                    case CardType.Two:
                        return 2;
                    case CardType.Three:
                        return 3;
                    case CardType.Four:
                        return 4;
                    case CardType.Five:
                        return 5;
                    case CardType.Six:
                        return 6;
                    case CardType.Seven:
                        return 7;
                    case CardType.Eight:
                        return 8;
                    case CardType.Nine:
                        return 9;
                    case CardType.Ten:
                        return 10;
                    case CardType.King:
                        return 10;
                    case CardType.Jack:
                        return 10;
                    case CardType.Queen:
                        return 10;
                    default:
                        return -1;
                }
            }
        }
}
