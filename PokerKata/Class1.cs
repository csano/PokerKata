using System.Collections.Generic;

namespace PokerKata
{
    public abstract class Hand
    {
        public LinkedList<Card> Cards { get; }
        public abstract int MaxCardCount { get; }

        private int count;

        protected Hand()
        {
            Cards = new LinkedList<Card>();
        }

        public void Add(Card card)
        {
            if (++count < MaxCardCount)
            {
                
            } 
        }

        public override string ToString()
        {
            return null;
        }
    }

    public class TexasHoldEmHand : Hand
    {
        public override int MaxCardCount => 2;
    }

    public class TexasHoldEmHandValidator 
    {

    }

    public class FiveCardStudHand : Hand
    {
        public override int MaxCardCount => 5;
    }
}
