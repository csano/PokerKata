using PokerKata.Cards.Values;
using PokerKata.UnitTests.Cards.Suits.StringRepresentation;

namespace PokerKata.UnitTests.Cards.Values.StringRepresentation
{
    public class TestingFiveStringRepresentation : TestingStringRepresentation<Five>
    {
        protected override string StringRepresentation => "5";
    }
}