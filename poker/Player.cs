using System;
using System.Collections.Generic;

namespace Poker
{
    internal class Player
    {
        public int ID { get; }
        public string Name { get; }
        public int Points { get; }
        public bool Human { get; }
        private readonly List<Card> _hand;

        internal Player(int id, string name, bool human, int points)
        {
            ID = id;
            Name = name;
            Human = human;
            Points = points;
            _hand = new List<Card>();
        }

        internal void GiveCard(Card card)
        {
            _hand.Add(card);
        }

        internal void GiveCard(object p)
        {
            throw new NotImplementedException();
        }
    }
}