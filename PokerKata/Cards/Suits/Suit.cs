using System;

namespace PokerKata.Cards.Suits
{
    public abstract class Suit : IComparable<Suit>, IEquatable<Suit>
    {
        public bool Equals(Suit other)
        {
            return other != null && ToString().Equals(other.ToString());
        }

        public override bool Equals(object obj)
        {
            return Equals((Suit) obj);
        }

        public int CompareTo(Suit other)
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
}