using System;
using System.Collections.Generic;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {            
            var participtGenerator = new ParticipantGenerator(new ParticipantBuilder());
            participtGenerator.GenerateParticipants("Billy", new List<string> { "Two of Spades", "Two of Spades", "Two of Hearts", "Four of Diamonds", "Five of Clubs" });
            participtGenerator.GenerateParticipants("Lemmy", new List<string> { "Ace of Spades", "Seven of Hearts", "Ace of Diamonds" });
            participtGenerator.GenerateParticipants("Andrew",new List<string> { "King of Daiamonds", "Four of Spades", "Four of Clubs" });  
            participtGenerator.GenerateParticipants("Carla", new List<string> { "Queen of Clubs", "Six of Spades", "Nine of Diamonds" });
            var players = participtGenerator.GetParticipants();
            var dealer = participtGenerator.GenerateParticipant("Dealer", new List<string> { "Jack of Spades", "Nine of Hearts" });

            BlackJackGame blackJackGame = new BlackJackGame();
            blackJackGame.PlayRoundOfBlackJack(players,dealer);
            WriteOutCome writeOutCome = new WriteOutCome(dealer,players);
            writeOutCome.WritePlayerRoundOutCome();
        }
    }
}
