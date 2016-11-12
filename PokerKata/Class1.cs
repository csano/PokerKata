using System;
using System.Collections.Generic;

namespace PokerKata
{
    public enum Value
    { Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
        Ace = 14
    }

    public enum Suit
    {
        Club,
        Diamond,
        Heart,
        Spade
    }

    public class Card : IEquatable<Card>
    {
        public Value Value { get; }
        public Suit Suit { get; }

        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }

        public bool Equals(Card other)
        {
            throw new NotImplementedException();
        }
    }

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
