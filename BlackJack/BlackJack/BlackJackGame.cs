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
            dealer.SumOfCards = TotalValue(dealer.PlayerCards);
            foreach (var player in players)
            {
                player.SumOfCards = TotalValue(player.PlayerCards);
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
        private int TotalValue(List<Card> cards)
        {
            int sum = cards.Select(x => x.Value).Sum();
            var aceCount = cards.Where(x => x.Value == 11).Select(x => x.Value).Count();
            while (aceCount > 1 && sum > 21) {
                sum = sum - 11 + 1;
                aceCount--;
            }
            return sum;

        }
    }

    }