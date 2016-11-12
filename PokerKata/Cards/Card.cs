using System;

namespace PokerKata.Cards
{
    public class Card : IEquatable<Card>, IComparable<Card>
    {
        public CardValue Value { get; }
        public Suit Suit { get; }

        public Card(CardValue value, Suit suit)
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
            return Value == other.Value && Suit.Equals(other.Suit);
        }

        public int CompareTo(Card other)
        {
            if (other == null)
            {
                return -1;
            }

            if (Value != other.Value)
            {
                return EvaluateForNonZeroReturn(() => Value > other.Value);
            }

            if (!Suit.Equals(other.Suit))
            {
                return Suit.CompareTo(other.Suit);
            }

            return 0;
        }

        private static int EvaluateForNonZeroReturn(Func<bool> condition)
        {
            return condition() ? -1 : 1;
        }

        public override bool Equals(object obj)
        {
            return Equals((Card) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((int) Value*397) ^ Suit.GetHashCode();
            }
        }
    }
}