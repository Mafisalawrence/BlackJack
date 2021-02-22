using System;
using System.Collections.Generic;
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
        public void SetSumOfCards(int sum)
        {
            _participant.SumOfCards = sum;
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

        public Participant GetParticipant()
        {
            var participant = _participant;
            Clear();
            return participant;
        }

        private void Clear() => _participant = new Participant();

    }
}
