using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class ParticipantGenerator
    {
        private readonly IParticipantBuilder _participantBuilder;
        private readonly List<Participant> _participants;
        public ParticipantGenerator(IParticipantBuilder participantBuilder)
        {
            _participantBuilder = participantBuilder;
            _participants = new List<Participant>();
        }

        public void GenerateParticipants(string name, List<string> cards)
        {
             _participants.Add(GenerateParticipant(name,cards));
        }
        public Participant GenerateParticipant(string name, List<string> cards)
        {
            _participantBuilder.SetName(name);
            _participantBuilder.SetCards(cards);
            _participantBuilder.SetSumOfCards();
            return _participantBuilder.GetParticipant();
        }
        public List<Participant> GetParticipants() => _participants;

    }
}
