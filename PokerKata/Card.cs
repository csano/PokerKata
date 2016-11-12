using System;

namespace PokerKata
{
    public abstract class CardSuit : IComparable<CardSuit>, IEquatable<CardSuit>
    {
        public bool Equals(CardSuit other)
        {
            return other != null && ToString().Equals(other.ToString());
        }

        public override bool Equals(object obj)
        {
            return Equals((CardSuit) obj);
        }

        public int CompareTo(CardSuit other)
        {
            if (other == null)
            {
                return -1;
            }
            return string.Compare(GetType().Name, other.GetType().Name, StringComparison.Ordinal);
        }

        public abstract override string ToString();

        public override int GetHashCode()
        {
            return GetType().Name.GetHashCode();
        }
    }

    public interface ICardValue
    {
        
    }

    public class Card : IEquatable<Card>, IComparable<Card>
    {
        public CardValue CardValue { get; }
        public SuitType SuitType { get; }

        public Card(CardValue cardValue, SuitType suitTypeType)
        {
            SuitType = suitTypeType;
            CardValue = cardValue;
        }

        public bool Equals(Card other)
        {
            if (other == null)
            {
                return false;
            }
            return CardValue == other.CardValue && SuitType == other.SuitType;
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

            if (!SuitType.Equals(other.SuitType))
            {
                return SuitType.CompareTo(other.SuitType);
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
                return ((int) CardValue*397) ^ (int)SuitType;
            }
        }
    }
}