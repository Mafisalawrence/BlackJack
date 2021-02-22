using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Participant
    {
        public string Name { get; set; }
        public List<Card> PlayerCards { get; set; } = new List<Card>(); 
        public int SumOfCards { get; set; }
        public string Status { get; set; }
    }
}
