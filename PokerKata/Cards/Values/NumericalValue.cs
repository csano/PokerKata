namespace PokerKata.Cards.Values
{
    public abstract class NumericalValue : Value
    {
        public override string ToString()
        {
            return Rank.ToString();
        }
    }
}