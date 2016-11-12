using PokerKata.Cards.Values;
using PokerKata.UnitTests.Cards.Suits.StringRepresentation;

namespace PokerKata.UnitTests.Cards.Values.StringRepresentation
{
    public class TestingSevenStringRepresentation : TestingStringRepresentation<SevenValue>
    {
        protected override string StringRepresentation => "7";
    }
}