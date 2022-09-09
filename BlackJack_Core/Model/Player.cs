using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Core.Model
{
    class Player
    {

        private int _chip;
        const int AceValue = 11;
        const int BlackJack = 21;
        public string Name { get; private set; }
        private List<Card> _hands; 
        public Player(string name,int chip)
        {
            _hands = new List<Card>();
            this.Name = name;
            this._chip = chip;
        }
        internal void Assignment(Card card)
        {
            _hands.Add(card);
        }
        internal int GetScore()
        {
            int score = 0;
            foreach (var item in _hands)
            {
                if (item.CardType == CardType.Ace)
                    continue;
                score += item.GetRank();
            }
            if (score + AceValue > BlackJack)
            {
                score++;
            }
            return score;
        }

    }
}
