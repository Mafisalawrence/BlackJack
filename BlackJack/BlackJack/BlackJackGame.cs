using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    class BlackJackGame
    {
        public List<Participant> PlayRoundOfBlackJack(List<Participant> players, Participant dealer)
        {
            foreach (var player in players)
            {
                player.Status =  CheckPlayerHandAgainstDealer(player.PlayerCards.Count(),player.SumOfCards, dealer.SumOfCards);
            }
            return players;
        }

        private string CheckPlayerHandAgainstDealer(int playerCardCount,int playerSum, int dealerSum)
        {
            if (playerCardCount == 5 || playerSum >= dealerSum && playerSum <= 21)
            {
                return OutComeStatus.BeatsDealer;
            }
            return OutComeStatus.Loses;
        }
    }
    }