using PokerKata.Cards.Values;
using PokerKata.UnitTests.Cards.Suits.StringRepresentation;

namespace PokerKata.UnitTests.Cards.Values.StringRepresentation
{
    public class TestingThreeStringRepresentation : TestingStringRepresentation<ThreeValue>
    {
        protected override string StringRepresentation => "3";
    }
}