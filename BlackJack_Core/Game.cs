using BlackJack_Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack_Core
{
    public class Game
    {
        Dictionary<string, Player> _players;
        Deck _deck;
        Player _dealer;
        public Game()
        {
            _players = new Dictionary<string, Player>();
            _deck = new Deck();
            _dealer = new Player("Dealer", 0);

        }

        public void AddPlayer(string name, int betValue)
        {
            if (!_players.ContainsKey(name.ToLower()))
            {
                _players.Add(name.ToLower(), new Player(name, betValue));
            }
        }

        public void Start()
        {
            
            foreach (var item in _players)
            {
                Card card = _deck.DrawCard();
                item.Value.Assignment(card);

            }
        }
    }
}