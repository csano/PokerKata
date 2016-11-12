namespace PokerKata.Cards.Values
{
    public class AceValue : Value
    {
        public override int Rank => 14;

        public override string ToString()
        {
            return "A";
        }
    }
}