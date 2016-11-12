namespace PokerKata.Cards.Values
{
    public class Ace : Value
    {
        public override int Rank => 14;

        public override string ToString()
        {
            return "A";
        }
    }
}