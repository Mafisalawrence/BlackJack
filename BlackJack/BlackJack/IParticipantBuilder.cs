using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public interface IParticipantBuilder
    {
        void SetName(string name);
        void SetSumOfCards(int sum);
        void SetCards(List<string> cards);
        Participant GetParticipant();
    }
}
