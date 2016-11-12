using System;

namespace PokerKata
{
    public class Card : IEquatable<Card>, IComparable<Card>
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

        public int CompareTo(Card other)
        {
            if (other == null)
            {
                return -1;
            }

            if (Value != other.Value)
            {
                return Value > other.Value ? -1 : 1;
            }

            if (Suit != other.Suit)
            {
                return Suit < other.Suit ? -1 : 1;
            }

            return 0;
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
}