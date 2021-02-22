using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class WriteOutCome
    {
        private readonly Participant _dealer;
        private readonly List<Participant> _players;
        public WriteOutCome(Participant dealer, List<Participant> players)
        {
            _dealer = dealer;
            _players = players;
        }
        public void WritePlayerRoundOutCome()
        {
            WriteParticipantHand(_dealer);
            foreach (var player in _players)
            {
                WriteParticipantHand(player);
                Console.WriteLine(player.Status);
            };
        }
        private void WriteParticipantHand(Participant participant)
        {
            Console.WriteLine(participant.Name);
            foreach (var card in participant.Cards)
            {
                Console.WriteLine(card.ToString());
            }
            Console.WriteLine(participant.SumOfCards);
        }
    }
}
