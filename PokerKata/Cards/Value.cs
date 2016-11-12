using System;

namespace PokerKata.Cards
{
    public abstract class Value : IComparable<Value>, IEquatable<Value>
    {
        public int CompareTo(Value other)
        {
            if (other == null)
            {
                return -1;
            }

            if (Rank > other.Rank)
            {
                return -1;
            }

            if (Rank < other.Rank)
            {
                return 1;
            }

            return 0;
        }

        public bool Equals(Value other)
        {
            return other != null && ToString().Equals(other.ToString());
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode() ^ Rank;
        }

        public abstract int Rank { get; }
        public abstract override string ToString();
    }
}