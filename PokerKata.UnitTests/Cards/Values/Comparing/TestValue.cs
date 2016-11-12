using PokerKata.Cards;

namespace PokerKata.UnitTests.Cards.Values.Comparing
{
    public class TestValue : Value
    {
        public override int Rank => 100;

        public override string ToString()
        {
            return "ZZZZ";
        }
    }
}