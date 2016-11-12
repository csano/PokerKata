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
        Clubs,
        Diamond,
        Heart,
        Spade
    }

    public class Card : IEquatable<Card>
    {
        public Value Value { get; }
        public Suit Suit { get; }

        public Card(Value value, Suit suit)
        {
            Suit = suit;
            Value = value;
        }

        public bool Equals(Card other)
        {
            if (other == null)
            {
                return false;
            }
            return Value == other.Value && Suit == other.Suit;
        }

        public override bool Equals(object obj)
        {
            return Equals((Card) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((int) Value*397) ^ (int) Suit;
            }
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
