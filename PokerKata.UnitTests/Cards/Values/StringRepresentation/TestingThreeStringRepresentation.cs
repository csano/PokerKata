using PokerKata.Cards.Values;
using PokerKata.UnitTests.Cards.Suits.StringRepresentation;

namespace PokerKata.UnitTests.Cards.Values.StringRepresentation
{
    public class TestingThreeStringRepresentation : TestingStringRepresentation<Three>
    {
        protected override string StringRepresentation => "3";
    }
}