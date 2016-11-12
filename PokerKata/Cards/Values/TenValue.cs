namespace PokerKata.Cards.Values
{
    public class TenValue : Value
    {
        public override int Rank => 10;

        public override string ToString()
        {
            return "T";
        }
    }
}