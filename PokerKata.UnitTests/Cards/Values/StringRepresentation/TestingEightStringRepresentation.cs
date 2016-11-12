using PokerKata.Cards.Values;
using PokerKata.UnitTests.Cards.Suits.StringRepresentation;

namespace PokerKata.UnitTests.Cards.Values.StringRepresentation
{
    public class TestingEightStringRepresentation : TestingStringRepresentation<EightValue>
    {
        protected override string StringRepresentation => "8";
    }
}