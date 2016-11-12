using System.Collections.Generic;

namespace PokerKata
{
    public class Hand
    {
        public LinkedList<Card> Cards { get; }
        public int MaxCardCount => 5;

        private int currentCount;

        protected Hand()
        {
            Cards = new LinkedList<Card>();
        }

        public void Add(Card card)
        {
            if (++currentCount < MaxCardCount)
            {

                
            } 
        }

        public override string ToString()
        {
            return null;
        }
    }
}
