using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokerKata
{
    public class Hand
    {
        public LinkedList<Card> Cards { get; }
        public int MaxCardCount => 5;

        public Hand()
        {
            Cards = new LinkedList<Card>();
        }

        public void Add(Card card)
        {
            Cards.AddFirst(card);
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            foreach (var card in Cards)
            {
                output.Append($"{card.Value.ToString().ToCharArray().First()}{card.Suit}");
            }
            return output.ToString();
        }
    }
}
