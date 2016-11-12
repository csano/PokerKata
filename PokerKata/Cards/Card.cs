using System;
using PokerKata.Cards.Suits;

namespace PokerKata.Cards
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
            return Value.Equals(other.Value) && Suit.Equals(other.Suit);
        }

        public int CompareTo(Card other)
        {
            if (other == null)
            {
                return -1;
            }

            if (!Value.Equals(other.Value))
            {
                return Value.CompareTo(other.Value);
            }

            if (!Suit.Equals(other.Suit))
            {
                return Suit.CompareTo(other.Suit);
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
                return Value.GetHashCode() ^ Suit.GetHashCode();
            }
        }
    }
}