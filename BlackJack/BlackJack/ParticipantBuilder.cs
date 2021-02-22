using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    public class ParticipantBuilder: IParticipantBuilder
    {
        private Participant _participant;
        public ParticipantBuilder()
        {
            _participant = new Participant();
        }
        public void SetName(string name)
        {
            _participant.Name = name;
        }
        public void SetCards(List<string> cards){
            cards.ForEach(x =>
            {
                var cardGenerator = new CardBuilder(x);
                var cardBuilder = new CardGenerator(cardGenerator);
                cardBuilder.GenerateCard();
                _participant.PlayerCards.Add(cardGenerator.GetCard());
                });
        }
        public void SetSumOfCards()
        {
            _participant.SumOfCards = TotalValue(_participant.PlayerCards);
        }

        public Participant GetParticipant()
        {
            var participant = _participant;
            Clear();
            return participant;
        }

        private void Clear() => _participant = new Participant();
        private int TotalValue(List<Card> cards)
        {
            int sum = cards.Select(x => x.Value).Sum();
            var aceCount = cards.Where(x => x.Value == 11).Select(x => x.Value).Count();
            while (aceCount > 1 && sum > 21)
            {
                sum = sum - 11 + 1;
                aceCount--;
            }
            return sum;

        }
    }
}
