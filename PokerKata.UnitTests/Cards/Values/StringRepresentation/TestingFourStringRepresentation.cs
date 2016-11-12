using PokerKata.Cards.Values;
using PokerKata.UnitTests.Cards.Suits.StringRepresentation;

namespace PokerKata.UnitTests.Cards.Values.StringRepresentation
{
    public class TestingFourStringRepresentation : TestingStringRepresentation<Four>
    {
        protected override string StringRepresentation => "4";
    }
}