using System;

namespace PokerKata
{
    public class Card : IEquatable<Card>, IComparable<Card>
    {
        public CardValue CardValue { get; }
        public Suit Suit { get; }

        public Card(CardValue cardValue, Suit suit)
        {
            Suit = suit;
            CardValue = cardValue;
        }

        public bool Equals(Card other)
        {
            if (other == null)
            {
                return false;
            }
            return CardValue == other.CardValue && Suit.Equals(other.Suit);
        }

        public int CompareTo(Card other)
        {
            if (other == null)
            {
                return -1;
            }

            if (CardValue != other.CardValue)
            {
                return EvaluateForNonZeroReturn(() => CardValue > other.CardValue);
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
                return ((int) CardValue*397) ^ Suit.GetHashCode();
            }
        }
    }
}