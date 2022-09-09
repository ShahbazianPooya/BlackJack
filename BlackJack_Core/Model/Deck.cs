using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Core.Model
{
    internal class Deck
    {
        readonly Stack<Card> cardList;


        internal Deck()
        {
            List<(Guid id, Card card)> cards = new List<(Guid id, Card card)>();

            cardList = new Stack<Card>(52);
            for (int i = 1; i < 14; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    Card card = new Card((Suit)j, (CardType)i);
                    cards.Add((Guid.NewGuid(), card));
                }

            }
            foreach (var item in cards.OrderBy(p => p.id))
            {
                cardList.Push(item.card);

            }
        }
        internal Card DrawCard()
        {
            if (cardList.Count == 0)
                throw new Exception("No Card");

            return cardList.Pop();
        }

    }
}
