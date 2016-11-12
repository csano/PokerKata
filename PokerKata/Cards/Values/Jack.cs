namespace PokerKata.Cards.Values
{
    public class Jack : Value
    {
        public override int Rank => 11;

        public override string ToString()
        {
            return "J";
        }
    }
}