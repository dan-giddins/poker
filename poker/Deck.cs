using System;
using System.Collections.Generic;

namespace Poker
{
    internal class Deck
    {
        private List<Card> _cards = new List<Card>();

        public Deck()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Suit)))
                {
                    _cards.Add(new Card(suit, rank));
                }
            }
        }

        internal Card RemoveRandomCard()
        {
            int index = GetRandomNumber(_cards.Count);
            Card card = _cards[index];
            _cards.RemoveAt(index);
            return card;
        }

        private int GetRandomNumber(int max)
        {
            Random rnd = new Random();
            return rnd.Next(max);
        }
    }
}