using System;
using System.Collections.Generic;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Poker");
            Console.WriteLine("-----");
            // generate players
            Board board = new Board();
            List<Player> players = new List<Player>();
            board.players = players;
            players.Add(new Player(0, "Player", true, 10));
            for (int i = 1; i < 4; i++)
            {
                players.Add(new Player(i, "bot" + i, false, 10));
            }
            // generate deck
            Deck deck = new Deck();
            board.deck = deck;
            // distrbute cards
            foreach (Player player in players)
            {
                for (int i = 0; i < 2; i++)
                {
                    player.GiveCard(deck.RemoveRandomCard());
                }
            }
            Console.ReadKey();
        }
    }
}
