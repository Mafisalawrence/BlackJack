using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Card
    {
        public string Type { get; set; }
        public string Suit { get; set; }
        public int Value { get; set; }

        public override string ToString() => $"{Type} of {Suit}";
    }
}
