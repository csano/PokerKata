namespace PokerKata.Cards.Values
{
    public class KingValue : Value
    {
        public override int Rank => 13;

        public override string ToString()
        {
            return "K";
        }
    }
}