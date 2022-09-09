using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Core.Model
{
    class Card
    {
        internal CardType CardType { get; private set; }
        internal Suit Type { get; private set; }
        internal Card(Suit type, CardType face)
        {

            this.Type = type;
            this.CardType = face;
        }
        internal int GetRank()
        {

            switch (CardType)
            {
                case CardType.Ten:
                case CardType.Jack:
                case CardType.Queen:
                case CardType.King:
                    return 10;
                case CardType.Ace:
                    return 11;
                default:
                    return (int)CardType;

            }
        }
    }
}
