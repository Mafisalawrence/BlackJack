using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public interface IParticipantBuilder
    {
        void SetName(string name);
        void SetCards(List<string> cards);
        void SetSumOfCards();
        Participant GetParticipant();
    }
}
